using System;
using System.Collections.Generic;
using UnityEngine;
using UnityWebSocket;

namespace HotUpdate.Code.Kernel.Network
{
    internal class ReceivePair
    {
        public byte[] Result;
        public int Length;
    }
    
    internal class WebClient
    {
        private readonly Queue<ReceivePair> _receiveMsgBuffer = new();
        private readonly Dictionary<RespId, Action<byte[]>> _callBacks = new();
        
        private IWebSocket WebSocket { get; set; }
        internal bool IsConnected { get; private set; }

        /// <summary>
        /// 连接WebSocket
        /// </summary>
        internal void Connection(string path, string account, int sId)
        {
            Close();
            
            // var s0 = TimerManager.Instance.GetCurrentTimeStamp();
            // var s1 = NetworkManager.Instance.GetSession1(s0, account);
            // var serverPath = $"{path}shbhj/{sId}/{account}/{s0}/{s1}";
            // #if UNITY_EDITOR
            // Debug.Log("serverPath:" + serverPath);
            // #endif
            var serverPath = $"{""}";
            WebSocket = new WebSocket(serverPath);
            WebSocket.OnOpen += SocketOnOpen;
            WebSocket.OnMessage += SocketOnMessage;
            WebSocket.OnClose += SocketOnClose;
            WebSocket.OnError += SocketOnError;
            WebSocket.ConnectAsync();
            
            NetworkManager.Instance.Machine.ChangeState<FsmConnecting>();
        }

        public void Destroy()
        {
            foreach (var keyValuePair in _callBacks)
            {
                
            }

            // WebSocket?.Destroy();
        }

        internal void Send(byte[] msg)
        {
            if (!IsConnected)
            {
                // Log.Error("WebClient Send：Socket not Connected");
                return;
            }
            
            WebSocket.SendAsync(msg);
        }

        internal void Update()
        {
            if (!IsConnected)
            {
                return;
            }

            if (_receiveMsgBuffer.Count != 0)
            {
                while (true)
                {
                    if (_receiveMsgBuffer.Count == 0)
                    {
                        break;
                    }

                    var msg = _receiveMsgBuffer.Dequeue();
                    OnReceive(msg.Result, msg.Length);
                }
            }
        }
        
        /// <summary>
        /// 关闭WebSocket
        /// </summary>
        internal void Close()
        {
            // Log.Error("WebClient Close");
            if (WebSocket != null && WebSocket.ReadyState != WebSocketState.Closed)
            {
                WebSocket.CloseAsync();
            }
            WebSocket = null;

            //注释掉，断线重连没有注册，收不到服务器返回的信息
            //_callBacks.Clear();
            _receiveMsgBuffer.Clear();
            IsConnected = false;
        }

        private void SocketOnOpen(object sender, OpenEventArgs e)
        {
            // Log.Error("WebClient SocketOnOpen");
            IsConnected = true;
            NetworkManager.Instance.Machine.ChangeState<FsmConnected>();
        }
        
        private void SocketOnMessage(object sender, MessageEventArgs e)
        {
            // Log.Error("WebClient SocketOnMessage");
            var pair = new ReceivePair
            {
                Result = e.RawData,
                Length = e.RawData.Length
            };
            _receiveMsgBuffer.Enqueue(pair);
        }
        
        private void SocketOnClose(object sender, CloseEventArgs e)
        {
            // Log.Error("WebClient SocketOnClose");
            Close();
            NetworkManager.Instance.Machine.ChangeState<FsmConnectClose>();
        }

        private void SocketOnError(object sender, ErrorEventArgs e)
        {
            // Log.Error("WebClient SocketOnError");
            Close();
            // NetworkManager.Instance.Machine.ChangeState<FsmConnectError>();
        }
        
        private void OnReceive(byte[] data, int totalLen)
        {
            if (data.Length == 0)
            {
                Debug.LogError("WebClient no receive data");
                return;
            }
            var id = BitConverter.ToInt32(data, 0);
            var respId = (RespId)id;
            // if (respId == RespId.ErrorRespId)
            // {
            //     //错误码。。。。 也可以注册一个Response
            //     Log.Error($"error code：{respId} ->{data}");
            //     return;
            // }
            if (!_callBacks.ContainsKey(respId))
            {
                return;
            }

            var callBack = _callBacks[respId];
            callBack.Invoke(data);
        }

        internal void Register(RespId respId, Action<byte[]> callBack)
        {
            _callBacks.TryAdd(respId, callBack);
        }
    }
}