using System.Collections.Generic;
using HotUpdate.Code.Kernel.Trie;

namespace HotUpdate.Code.Kernel.RedDot
{
    public class RedDotManager: Manager<RedDotManager>
    {
        private readonly TrieMap _trieMap = new();
        private readonly List<int> _cacheInt = new(16);
        
        protected override void OnInitialize()
        {
            
        }

        protected override void OnSignIn()
        {
            _trieMap.Clear();
            _cacheInt.Clear();
        }

        protected override void OnSignOut()
        {
            _trieMap.Clear();
            _cacheInt.Clear();
        }

        protected override void OnDestroy()
        {
            _trieMap.Clear();
            _cacheInt.Clear();
        }

        #region Refresh
        public void Refresh(int record, int key0)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _trieMap.Refresh(record, _cacheInt);
        }
        
        public void Refresh(int record, int key0, int key1)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _trieMap.Refresh(record, _cacheInt);
        }

        public void Refresh(int record, int key0, int key1, int key2)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _trieMap.Refresh(record, _cacheInt);
        }
        public void Refresh(int record, int key0, int key1, int key2, int key3)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _cacheInt.Add(key3);
            _trieMap.Refresh(record, _cacheInt);
        }
        
        public void Refresh(int record, int key0, int key1, int key2, int key3, int key4)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _cacheInt.Add(key3);
            _cacheInt.Add(key4);
            _trieMap.Refresh(record, _cacheInt);
        }
        
        public void Refresh(int record, int key0, int key1, int key2, int key3, int key4, int key5)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _cacheInt.Add(key3);
            _cacheInt.Add(key4);
            _cacheInt.Add(key5);
            _trieMap.Refresh(record, _cacheInt);
        }
        
        public void Refresh(int record, int key0, int key1, int key2, int key3, int key4, int key5, int key6)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _cacheInt.Add(key3);
            _cacheInt.Add(key4);
            _cacheInt.Add(key5);
            _cacheInt.Add(key6);
            _trieMap.Refresh(record, _cacheInt);
        }
        
        public void Refresh(int record, int[] keys)
        {
            _cacheInt.Clear();
            var length = keys.Length;
            for (var i = 0; i < length; i++)
            {
                _cacheInt.Add(keys[i]);
            }
            _trieMap.Refresh(record, _cacheInt);
        }
        #endregion
        
        #region GetRecord
        public int GetRecord(int key0)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            return _trieMap.GetRecord(_cacheInt);
        }
        public int GetRecord(int key0, int key1)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            return _trieMap.GetRecord(_cacheInt);
        }
        public int GetRecord(int key0, int key1, int key2)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            return _trieMap.GetRecord(_cacheInt);
        }
        public int GetRecord(int key0, int key1, int key2, int key3)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _cacheInt.Add(key3);
            return _trieMap.GetRecord(_cacheInt);
        }
        public int GetRecord(int key0, int key1, int key2, int key3, int key4)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _cacheInt.Add(key3);
            _cacheInt.Add(key4);
            return _trieMap.GetRecord(_cacheInt);
        }
        public int GetRecord(int key0, int key1, int key2, int key3, int key4, int key5)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _cacheInt.Add(key3);
            _cacheInt.Add(key4);
            _cacheInt.Add(key5);
            return _trieMap.GetRecord(_cacheInt);
        }
        public int GetRecord(int key0, int key1, int key2, int key3, int key4, int key5, int key6)
        {
            _cacheInt.Clear();
            _cacheInt.Add(key0);
            _cacheInt.Add(key1);
            _cacheInt.Add(key2);
            _cacheInt.Add(key3);
            _cacheInt.Add(key4);
            _cacheInt.Add(key5);
            _cacheInt.Add(key6);
            return _trieMap.GetRecord(_cacheInt);
        }
        
        public int GetRecord(int[] keys)
        {
            _cacheInt.Clear();
            var length = keys.Length;
            for (var i = 0; i < length; i++)
            {
                _cacheInt.Add(keys[i]);
            }
            return _trieMap.GetRecord(_cacheInt);
        }
        
        public bool HasRedDot(int[] keys)
        {
            var record = GetRecord(keys);
            var has = record > 0;
            return has;
        }
        #endregion
    }
}