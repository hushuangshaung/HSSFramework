using System;
using UniFramework.Machine;

namespace HotUpdate.Code.Kernel.Network
{
    public class NetworkManager: Manager<NetworkManager>
    {
        private WebClient WebClient { get; set; }
        internal StateMachine Machine { get; private set; }
        
        /// <summary>
        /// 第一次连接
        /// </summary>
        internal bool IsFirstConnect { get; private set; }
        internal int ConnectionCount { get; set; }
        
        public bool IsConnected
        {
            get
            {
                if (WebClient == null)
                {
                    return false;
                }

                return WebClient.IsConnected;
            }
        }
        
        private string _account;
        private string _url;
        private int _id;

        protected override void OnInitialize()
        {
            Machine = new StateMachine(this);
            Machine.AddNode<FsmInitialize>();
            Machine.AddNode<FsmConnecting>();
            Machine.AddNode<FsmConnected>();
            Machine.AddNode<FsmConnectError>();
            Machine.AddNode<FsmConnectClose>();

            Machine.Run<FsmInitialize>();
            WebClient = new WebClient();
            
            GameManager.RegisterTick(Tick);
        }
        
        protected override void OnSignIn()
        {
            
        }
        
        protected override void OnSignOut()
        {
            Close();
        }
        
        protected override void OnDestroy()
        {
        }
        
        
        private void Tick(float obj)
        {
            Machine?.Update();
            WebClient?.Update();
        }
        
        /// <summary>
        /// 内部调用，比如断线重连
        /// </summary>
        internal void Connection()
        {
            ConnectionCount++;
            WebClient?.Connection(_url, _account, _id);
        }
        
        /// <summary>
        /// 登录时调用
        /// </summary>
        /// <param name="url"></param>
        /// <param name="account"></param>
        /// <param name="id"></param>
        public void Connection(string url, string account, int id)
        {
            ConnectionCount++;
            _url = url;
            _account = account;
            _id = id;
            WebClient?.Connection(_url, _account, _id);
        }
        
        /// <summary>
        /// 关闭WebSocket
        /// </summary>
        public void Close()
        {
            WebClient?.Close();
        }
        
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="msg"></param>
        internal void Send(byte[] msg)
        {
            WebClient?.Send(msg);
        }
        
        /// <summary>
        /// 注册回调
        /// </summary>
        /// <param name="respId"></param>
        /// <param name="callBack"></param>
        internal void Register(RespId respId, Action<byte[]> callBack)
        {
            WebClient?.Register(respId, callBack);
        }
    }
}