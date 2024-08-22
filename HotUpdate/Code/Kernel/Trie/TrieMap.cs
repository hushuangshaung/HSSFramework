using System.Collections.Generic;
using UnityEngine;

namespace HotUpdate.Code.Kernel.Trie
{
    public class TrieMap
    {
        private readonly TrieMapNode _root = new();

        public void Clear()
        {
            _root.Clear();
        }

        public void Refresh(int record, List<int> keys)
        {
            var count = keys.Count;
            if (count > 10)
            {
                Log.Error($"keys 长度不能超过10: {string.Join(" ", keys)}");
            }

            var current = _root;
            foreach (var key in keys)
            {
                if (!current.Children.ContainsKey(key))
                {
                    var newTrieNode = new TrieMapNode
                    {
                        Key = key,
                        Parent = current
                    };

                    current.Children.Add(key, newTrieNode);
                }

                current = current.Children[key];
            }

            if (current.Children.Count != 0)
            {
                Log.Error($"不允许直接改变非叶子节点的值: { string.Join(" ", keys)}");
                return;
            }

            current.Record = record;
            
            //回溯  如果上一次记录是和这一次记录是一样的，则不回溯
            var add = current.Record - current.LastRecord;
            if (add == 0)
            {
                return;
            }
            current.LastRecord = current.Record;
            BackTrack(current, add);
        }
        
        private static void BackTrack(TrieMapNode node, int add)
        {
            while (true)
            {
                if (node.Parent?.Parent == null)
                {
                    return;
                }

                node.Parent.ChildrenRecord += add;
                node = node.Parent;
            }
        }
        
        public int GetRecord(List<int> keys)
        {
            var current = _root;
            var count = keys.Count;
            var record = 0;
            for (var i = 0; i < count; i++)
            {
                var key = keys[i];
                if (current.Children.TryGetValue(key, value: out var child))
                {
                    current = child;
                    if (i == count - 1)
                    {
                        return current.Record + current.ChildrenRecord;
                    }
                }
                else
                {
                    break;
                }
            }

            return record;
        }
    }
}