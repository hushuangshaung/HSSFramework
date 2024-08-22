using System.Collections;
using UniFramework.Machine;
using UnityEngine;

namespace HotUpdate.Code.Kernel.Network
{
    internal class FsmConnectClose: IStateNode
    {
        private StateMachine _machine;
        void IStateNode.OnCreate(StateMachine machine)
        {
            _machine = machine;
        }

        void IStateNode.OnEnter()
        {
            GameManager.StartCoroutine(Connecting());
        }
        
        void IStateNode.OnUpdate()
        {
            
        }

        void IStateNode.OnExit()
        {
            
        }
        
        private IEnumerator Connecting()
        {
            yield return new WaitForSeconds(5);
            //弹出一个弹窗， 状态切换到FsmConnecting
            //           Debug.LogError($"连接失败次数:{NetworkManager.Instance.ConnectionCount}");
            //当大于某个次数时，就弹出确认框，返回到Initalize场景
            // if (NetworkManager.Instance.ConnectionCount >= 10)
            // {
            //     //SceneManager.LoadSceneAsync("Initialize");
            // }
            // else
            // {
            //     _machine.ChangeState<FsmConnecting>();
            //     NetworkManager.Instance.Connection();
            // }
            _machine.ChangeState<FsmConnecting>();
            NetworkManager.Instance.Connection();
        }
    }
}