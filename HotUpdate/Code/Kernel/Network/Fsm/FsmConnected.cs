using UniFramework.Machine;

namespace HotUpdate.Code.Kernel.Network
{
    internal class FsmConnected: IStateNode
    {
        private StateMachine _machine;
         
        void IStateNode.OnCreate(StateMachine machine)
        {
            _machine = machine;
        }
        
        void IStateNode.OnEnter()
        {
            NetworkManager.Instance.ConnectionCount = 0;
            //链接成功之后，发送登录协议
            // UIReconnectEvent.SendEventMessage(1);
            // var id = ServerManager.Instance.CurrentId;
            // LoginProto.Instance.Send(LoginManager.Instance.Code, id);
        }
        
        void IStateNode.OnUpdate()
        {
            
        }
        
        void IStateNode.OnExit()
        {
            
        }
    }
}