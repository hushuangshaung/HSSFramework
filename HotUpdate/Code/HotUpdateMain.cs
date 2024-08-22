using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using YIUIFramework;
using YooAsset;
using Object = UnityEngine.Object;

public class HotUpdateMain: MonoBehaviour
{
    private ResourcePackage package;
    IEnumerator Start()
    {
        GameManager.SetMonoBehaviour(this);
        DontDestroyOnLoad(this);
        Debug.Log("hello, HybridCLR");

        //初始化配置表
        ConfigManager.Instance.InitConfig();
        while (!ConfigManager.Instance.InitSuccess)
        {
            yield return new WaitForSeconds(0.2f);
        }
        
        var btnSortData = ConfigManager.Instance.CfgTables.BtnSort.GetOrDefault(1);
        // Debug.LogError(JsonMapper.ToJson(btnSortData));
        Debug.LogError(btnSortData.Quality.ToString());
        
        ManagerRegister.Register();
        
        InitYIUI();
    }
    
    private void Update()
    {
        GameManager.Update(Time.deltaTime);
    }
    
    private void FixedUpdate()
    {
        GameManager.FixedUpdate(Time.fixedTime);
    }

    private void LateUpdate()
    {
        GameManager.LateUpdate(Time.deltaTime);
    }

    private void OnDestroy()
    {
        Manager.Destroy();
    }

    #region 初始化YIUI
    private Dictionary<int, AssetHandle> m_AllHandle = new();

    private void InitYIUI()
    {
        //关联UI工具中自动生成绑定代码 Tools >> YIUI自动化工具 >> 发布 >> UI自动生成绑定替代反射代码
        UIBindHelper.InternalGameGetUIBindVoFunc = YIUICodeGenerated.UIBindProvider.Get;
            
        //YIUI会用到的各种加载 需要自行实现 使用的是YooAsset 根据自己项目的资源管理器实现下面的方法
        YIUILoadDI.LoadAssetFunc                 = LoadAsset;       //同步加载
        YIUILoadDI.LoadAssetAsyncFunc            = LoadAssetAsync;  //异步加载
        YIUILoadDI.ReleaseAction                 = ReleaseAction;   //释放
            
        //验证
        YIUILoadDI.VerifyAssetValidityFunc       = VerifyAssetValidityFunc;
        
        StartOpenPanel().Forget();
    }
    
    /// <summary>
    /// 释放方法
    /// </summary>
    /// <param name="hashCode">加载时所给到的唯一ID</param>
    private void ReleaseAction(int hashCode)
    {
        if (m_AllHandle.TryGetValue(hashCode, out var value))
        {
            value.Release();
            m_AllHandle.Remove(hashCode);
        }
        else
        {
            Debug.LogError($"释放了一个未知Code");
        }
    }
    
    private bool VerifyAssetValidityFunc(string arg1, string arg2)
    {
        return package.CheckLocationValid(arg2);
    }
    
    /// <summary>
    /// 异步加载
    /// </summary>
    /// <param name="arg1">包名</param>
    /// <param name="arg2">资源名</param>
    /// <param name="arg3">类型</param>
    /// <returns>返回值(obj资源对象,唯一ID)</returns>
    private async UniTask<(Object, int)> LoadAssetAsync(string arg1, string arg2, Type arg3)
    {
        var handle = package.LoadAssetAsync(arg2, arg3);
        await handle.ToUniTask(); //异步等待 需要实现YooAsset在UniTask中的异步扩展
        return LoadAssetHandle(handle);
    }
    
    /// <summary>
    /// 同步加载
    /// </summary>
    /// <param name="arg1">包名</param>
    /// <param name="arg2">资源名</param>
    /// <param name="arg3">类型</param>
    /// <returns>返回值(obj资源对象,唯一ID)</returns>
    private (Object, int) LoadAsset(string arg1, string arg2, Type arg3)
    {
        var handle = package.LoadAssetSync(arg2, arg3);
        return LoadAssetHandle(handle);
    }
    
    //只有成功加载才返回 否则直接释放
    private (Object, int) LoadAssetHandle(AssetHandle handle)
    {
        if (handle.AssetObject != null)
        {
            var hashCode = handle.GetHashCode();
            m_AllHandle.Add(hashCode, handle);
            return (handle.AssetObject, hashCode);
        }

        handle.Release();
        return (null, 0);
    }
    
    private async UniTaskVoid StartOpenPanel()
    {
        SingletonMgr.Initialize();
        // await I2LocalizeMgr.Inst.ManagerAsyncInit();
        //以下是YIUI中已经用到的管理器 在这里初始化
        // await MgrCenter.Inst.Register(CountDownMgr.Inst);
        // await MgrCenter.Inst.Register(RedDotMgr.Inst);
        // await MgrCenter.Inst.Register(PanelMgr.Inst);
            
        OpenPanel();
    }
    
    public void OpenPanel()
    {
        //TODO 在这里打开你的第一个界面
        Debug.LogError("打开第一个ui或者场景");
        // Two.OpenLoginPanel();
    }
    #endregion
}