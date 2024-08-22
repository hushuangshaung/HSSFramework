using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniFramework.Event;
using YooAsset;

public class InitHelper
{
    private static InitHelper _instance;
    public static InitHelper Instance
    {
        get
        {
            if (_instance == null)
                _instance = new InitHelper();
            return _instance;
        }
    }
    /// <summary>
    /// AOT 补充
    /// </summary>
    public static List<string> AotDllList = new()
    {
        "mscorlib.dll",
        "System.dll",
        "System.Core.dll",
    };
    /// <summary>
    /// 热更dll
    /// </summary>
    public static List<string> HotUpdateDllList = new()
    {
        "Google.Protobuf.dll",
        "HotUpdate.dll",
    };

    private readonly EventGroup _eventGroup = new EventGroup();

    /// <summary>
    /// 协程启动器
    /// </summary>
    public MonoBehaviour Behaviour;

    private InitHelper()
    {
        // 注册监听事件
        _eventGroup.AddListener<SceneEventDefine.ChangeToHomeScene>(OnHandleEventMessage);
        _eventGroup.AddListener<SceneEventDefine.ChangeToBattleScene>(OnHandleEventMessage);
    }

    /// <summary>
    /// 开启一个协程
    /// </summary>
    public void StartCoroutine(IEnumerator enumerator)
    {
        Behaviour.StartCoroutine(enumerator);
    }
    /// <summary>
    /// 关闭一个协程
    /// </summary>
    /// <param name="enumerator"></param>
    public void StopCoroutine(IEnumerator enumerator)
    {
        Behaviour.StopCoroutine(enumerator);
    }

    /// <summary>
    /// 接收事件
    /// </summary>
    private void OnHandleEventMessage(IEventMessage message)
    {
        if (message is SceneEventDefine.ChangeToHomeScene)
        {
            YooAssets.LoadSceneAsync("scene_home");
        }
        else if (message is SceneEventDefine.ChangeToBattleScene)
        {
            YooAssets.LoadSceneAsync("scene_battle");
        }
    }
}