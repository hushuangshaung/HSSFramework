using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using HybridCLR;
using UniFramework.Event;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_WEBGL && WEIXINMINIGAME
using WeChatWASM;
#endif
using YooAsset;

public enum DllLoadMode
{
    LocalScript,
    HotFixDll,
}

public class Init: MonoBehaviour
{
    /// <summary>
    /// 资源系统运行模式
    /// </summary>
    public EPlayMode PlayMode = EPlayMode.EditorSimulateMode; 
    public DllLoadMode DLL = DllLoadMode.HotFixDll;

    public string DefaultHostServer = "http://test.res:8083";
    public string FallbackHostServer = "http://test.res:8083";
    private object _gameInstance;
    void Awake()
    {
        Application.targetFrameRate = 30;
        Application.runInBackground = true;
        // DontDestroyOnLoad(gameObject);
        
#if UNITY_WEBGL && !UNITY_EDITOR
        PlayMode = EPlayMode.WebPlayMode;
#elif UNITY_ANDROID && !UNITY_EDITOR
        //TODO (Android和IOS平台应用HostPlayMode模式)
        PlayMode = EPlayMode.OfflinePlayMode;
#endif
        
#if !UNITY_EDITOR
        DLL = DllLoadMode.HotFixDll;
#endif
        // Debug.Log($"资源系统运行模式：{PlayMode}");
    }
    
    void Start()
    {
        // 主工程游戏管理器
        InitHelper.Instance.Behaviour = this;
        InitHelper.Instance.DefaultHostServer = DefaultHostServer;
        InitHelper.Instance.FallbackHostServer = FallbackHostServer;
        
#if UNITY_WEBGL && WEIXINMINIGAME && !UNITY_EDITOR
        // Debug.Log("WX");
        WX.InitSDK((ret) =>
        {
            Debug.Log($"WX.env:{WX.env.USER_DATA_PATH}");
            //主逻辑
            InitHelper.Instance.StartCoroutine(StartHandle());
        });
        // WX.env.USER_DATA_PATH
        // WX.GetSystemInfo(new GetSystemInfoOption());
#else
        // Debug.Log("no - WX");
        StartCoroutine(StartHandle());
#endif

    }

    private IEnumerator StartHandle()
    {
        // 初始化事件系统
        UniEvent.Initalize();

        // 初始化资源系统
        YooAssets.Initialize();
        YooAssets.SetOperationSystemMaxTimeSlice(30);

        // 加载更新页面
        var patchWindow = Resources.Load<GameObject>("PatchWindow");
        Instantiate(patchWindow);
        
        // 开始补丁更新流程
        PatchOperation operation = new PatchOperation("DefaultPackage", PlayMode);
        YooAssets.StartOperation(operation);
        yield return operation;
        
        // 设置默认的资源包
        var gamePackage = YooAssets.GetPackage("DefaultPackage");
        YooAssets.SetDefaultPackage(gamePackage);
        //加载热更脚本
        //补充AOT元数据
        var mode = HomologousImageMode.SuperSet;
        //补充元数据
        foreach (var aotDllName in InitHelper.AotDllList)
        {
            // Debug.Log($"aotDllName:{aotDllName}");
            var handle = YooAssets.LoadAssetAsync<TextAsset>(aotDllName);
            yield return handle;
            var textAsset = handle.AssetObject as TextAsset;
            if (textAsset != null && textAsset.bytes != null)
            {
                var dllBytes = textAsset.bytes;
                // Debug.Log($"补充元数据：{dllBytes.Length}");
                // 加载assembly对应的dll，会自动为它hook。一旦aot泛型函数的native函数不存在，用解释器版本代码
                var err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, mode);
                // Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. mode:{mode} ret:{err}");
            }
        }
        //加载热更dll
        if (DLL == DllLoadMode.LocalScript)
        {
            AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "HotUpdate");
        }
        else
        {
            foreach (var hotUpdateDllName in InitHelper.HotUpdateDllList)
            {
                var handle = YooAssets.LoadAssetAsync<TextAsset>(hotUpdateDllName);
                yield return handle;
                var textAsset = handle.AssetObject as TextAsset;
                if (textAsset != null && textAsset.bytes != null)
                {
                    var dllBytes = textAsset.bytes;
                    var hotUpdateAssembly = Assembly.Load(dllBytes);
                    
                    // 在第一次使用某热更新类型时（主线程AddComponent或者资源线程加载含脚本的资源）会触发引擎创建MonoScript数据，然而此操作并非线程安全。
                    // 由于未接入hybridclr时，所有脚本都在启动时已经初始化，因此不会有线程安全问题。
                    // 当接入hybridclr后，在偶然情况下（尤其是加载包含大量脚本的资源）会触发这个问题。
                    // 解决办法：
                    // 加载完热更新程序集后，通过临时创建的GameObject,把所有热更新脚本都添加一遍，类似这样：
                    // var tempGo = new GameObject();
                    // tempGo.SetActive(false);
                    // foreach (var type in hotUpdateAssembly.GetTypes())
                    // {
                    //     if (typeof(MonoBehaviour).IsAssignableFrom(type))
                    //     {
                    //         tempGo.AddComponent(type);
                    //     }
                    // }
                    // Destroy(tempGo);
                }
            }
        }
        {
            //加载挂载热更主入口的Prefab
            var hotUpdateMainHandle = YooAssets.LoadAssetAsync<GameObject>("HotUpdateMain");
            yield return hotUpdateMainHandle;
            Instantiate(hotUpdateMainHandle.AssetObject);
            hotUpdateMainHandle.Release();
        }
    }
}