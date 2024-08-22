using UniFramework.Machine;

namespace HotUpdate.Code.Kernel.Network
{
    public class FsmConnectError: IStateNode
    {
        private StateMachine _machine;
        void IStateNode.OnCreate(StateMachine machine)
        {
            _machine = machine;
        }

        void IStateNode.OnEnter()
        {
            
        }
        
        void IStateNode.OnUpdate()
        {
            
        }

        void IStateNode.OnExit()
        {
            
        }
    }
}