using System;
using System.Collections.Generic;
using System.Text;
using Google.Protobuf;
using UnityEngine;

namespace HotUpdate.Code.Kernel.Network
{
    public class ProtoBase<T1, T2>: Singleton<T1> where T1: ProtoBase<T1, T2>, new() where T2: IMessage, new()
    {
        private ReqId _reqId;
        private RespId _respId;
        private Action<T2> _callBack;
        
        private float _intervalTime = 0.1f;
        private float _lastRequestTime;
        
        /// <summary>
        /// 协议对
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="respId"></param>
        protected void Register(ReqId reqId, RespId respId)
        {
            _reqId = reqId;
            NetworkManager.Instance.Register(respId, Response);
        }
        
        /// <summary>
        /// 只发送消息
        /// </summary>
        /// <param name="reqId"></param>
        protected void Register(ReqId reqId)
        {
            _reqId = reqId;
        }
        
        /// <summary>
        /// 只接收消息
        /// </summary>
        /// <param name="respId"></param>
        protected void Register(RespId respId)
        {
            NetworkManager.Instance.Register(respId, Response);
        }

        /// <summary>
        /// 小于0 不限制
        /// </summary>
        /// <param name="intervalTime"></param>
        protected void SetIntervalTime(float intervalTime)
        {
            _intervalTime = intervalTime;
        }

        /// <summary>
        /// 只接收消息的监听
        /// </summary>
        public void AddListener()
        {
            
        }
        
        protected void BaseSend()
        {
            if (Time.time - _lastRequestTime <= _intervalTime)
            {
                return;
            }
            _lastRequestTime = Time.time;
            
            var reqId = (int)_reqId;
            var bit = BitConverter.GetBytes(reqId);
#if UNITY_EDITOR
            Debug.Log($"<color=green>ReqId:{_reqId}</color>");
#else
            Debug.Log($"ReqId:{_reqId}");
#endif
            if (bit.Length < 4)
            {
                var data = new byte[4];
                Array.Copy(bit, 0, data, 0, 4);
                NetworkManager.Instance.Send(data);
            }
            else
            {
                NetworkManager.Instance.Send(bit);
            }
        }
        
        private static List<byte> _datas = new(128);
        protected void BaseSend<T0>(T0 proto) where T0 : IMessage
        {
            if (Time.time - _lastRequestTime <= _intervalTime)
            {
                return;
            }
            _lastRequestTime = Time.time;
            _datas.Clear();
            var proArray = proto.ToByteArray();
            var base64 = Convert.ToBase64String(proArray);
            var msg = Encoding.UTF8.GetBytes(base64);
            
            var reqId = (int)_reqId;
            var bit = BitConverter.GetBytes(reqId);
            
            if (bit.Length < 4)
            {
                var data = new byte[4];
                Array.Copy(bit, 0, data, 0, 4);
                _datas.AddRange(data);
            }
            else
            {
                _datas.AddRange(bit);
            }
            _datas.AddRange(msg);
            
            var bytes = _datas.ToArray();
            NetworkManager.Instance.Send(bytes);
#if UNITY_EDITOR
            var s = proto.ToString();
            Debug.Log($"<color=green>Request:{typeof(T0)}:{s}</color>");
#else
            var s = proto.ToString();
            Debug.Log($"Request:{typeof(T0)}:{s}");
#endif
        }
        
        
        private void Response(byte[] message)
        {
            var proto = Deserialize(message);
#if UNITY_EDITOR
            var s = proto.ToString();
            Debug.Log($"<color=green>Response:{typeof(T2)}:{s}</color>");   
#else
            var s = proto.ToString();
            Debug.Log($"Response:{typeof(T2)}:{s}");  
#endif
            Response(proto);
            _callBack?.Invoke(proto);
        }
        protected virtual void Response(T2 message){ }
        
        private static T2 Deserialize(byte[] data)
        {
            var proto = new T2();
            var cis = new CodedInputStream(data, 4, data.Length - 4);
            proto.MergeFrom(cis);
            return proto;
        }
    }
}