using System.Collections.Generic;
using HotUpdate.Code.Kernel.Camera;
using HotUpdate.Code.Kernel.Network;
using HotUpdate.Code.Kernel.RedDot;
using YooAsset;

public class ManagerRegister: GameAsyncOperation
{
    /// <summary>
    /// 正在初始化列表
    /// </summary>
    private List<IManager> _isInitializeList;
    
    private readonly List<IManager> _list = new()
    {
        NetworkManager.Instance,
        RedDotManager.Instance,
        CameraManager.Instance,
    };

    protected override void OnStart()
    {
        _isInitializeList = _list;
        Manager.Initaialize(_list);
    }

    protected override void OnUpdate()
    {
        var count = _isInitializeList.Count;
        for (var i = count - 1; i >= 0; i--)
        {
            var manger = _isInitializeList[i];
            if (manger.IsInitialized())
            {
                _isInitializeList.RemoveAt(i);
            }
        }

        if (_isInitializeList.Count == 0)
        {
            Status = EOperationStatus.Succeed;
            Manager.Initialized();
        }
    }

    protected override void OnAbort()
    {
        
    }
}