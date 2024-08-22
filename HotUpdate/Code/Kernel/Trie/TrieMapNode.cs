using System.Collections.Generic;

namespace HotUpdate.Code.Kernel.Trie
{
    public class TrieMapNode
    {
        public int Key;
        /// <summary>
        /// 上一次的记录
        /// </summary>
        public int LastRecord;
        /// <summary>
        /// 本次记录
        /// </summary>
        public int Record;

        /// <summary>
        /// 子节点记录
        /// </summary>
        public int ChildrenRecord;
        public TrieMapNode Parent;
        public readonly Dictionary<int, TrieMapNode> Children = new();

        public void Clear()
        {
            Key = 0;
            LastRecord = 0;
            Record = 0;

            ChildrenRecord = 0;
            Parent = null;
            Children.Clear();
        }
    }
}