using UniFramework.Machine;

namespace HotUpdate.Code.Kernel.Network
{
    internal class FsmConnecting : IStateNode
    {
        private StateMachine _machine;

        void IStateNode.OnCreate(StateMachine machine)
        {
            _machine = machine;
        }
        void IStateNode.OnEnter()
        {
            //     if (NetworkManager.Instance.ConnectionCount == 1)
            //     {
            //         //第一次连接
            // //        Log.Error("第一次连接ing");
            //     }
            //     else
            //     {
            //         //重连
            //  //       Log.Error($"重新连接ing：{NetworkManager.Instance.ConnectionCount}");
            //     }
            // UIReconnectEvent.SendEventMessage(0);
        }

        void IStateNode.OnUpdate()
        {
            
        }
        
        void IStateNode.OnExit()
        {
            
        }
    }
}