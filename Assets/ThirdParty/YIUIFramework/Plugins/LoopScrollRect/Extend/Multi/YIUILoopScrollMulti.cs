using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace YIUIFramework
{
    public partial class YIUILoopScrollMulti<TData> : LoopScrollPrefabSource, LoopScrollMultiDataSource
    {
        /// <summary>
        /// 列表项渲染器
        /// </summary>
        /// <param name="index">数据的索引</param>
        /// <param name="data">数据项</param>
        /// <param name="item">显示对象</param>
        /// <param name="select">是否被选中</param>
        public delegate void ListItemRenderer(int index, TData data, UIBase item, bool select);

        private ListItemRenderer m_ItemRenderer;

        private List<UIBase> _pool = new();
        private Type[] _types;

        private Dictionary<Type, UIBindVo> m_BindVos = new();
        private IList<TData> m_Data;
        private LoopScrollRectMulti m_Owner;
        private Dictionary<Type, ObjCache<UIBase>> m_UIBasePools = new();
        private Dictionary<Transform, UIBase> m_ItemTransformDic = new();
        private Dictionary<Transform, int> m_ItemTransformIndexDic = new();

        public YIUILoopScrollMulti(LoopScrollRectMulti owner, ListItemRenderer itemRenderer, params Type[] types)
        {
            var count = types.Length;
            if (count == 0)
            {
                return;
            }

            _pool.Clear();
            m_BindVos.Clear();
            m_UIBasePools.Clear();
            m_ItemTransformDic.Clear();
            m_ItemTransformIndexDic.Clear();

            for (var i = 0; i < count; i++)
            {
                var type = types[i];
                var data = UIBindHelper.GetBindVoByType(type);
                if (data != null)
                {
                    m_BindVos.Add(type, data.Value);
                    m_UIBasePools.Add(type, new ObjCache<UIBase>(() =>

                        OnCreateItemRenderer(type)
                    ));

                    var uiBase = Activator.CreateInstance(type);
                    if (!(uiBase is UIBase))
                    {
                        Debug.LogError($"{type} not extend UIBase");
                        return;
                    }

                    _pool.Add(uiBase as UIBase);
                }
            }

            m_ItemRenderer = itemRenderer;

            m_Owner = owner;
            m_Owner.prefabSource = this;
            m_Owner.dataSource = this;
            InitCacheParent();
            InitClearContent();
        }

        #region Private

        private void InitCacheParent()
        {
            if (m_Owner.u_CacheRect != null)
            {
                m_Owner.u_CacheRect.gameObject.SetActive(false);
            }
            else
            {
                var cacheObj = new GameObject("Cache");
                var cacheRect = cacheObj.GetOrAddComponent<RectTransform>();
                m_Owner.u_CacheRect = cacheRect;
                cacheRect.SetParent(m_Owner.transform, false);
                cacheObj.SetActive(false);
            }
        }

        private void InitClearContent()
        {
            //不应该初始化时有内容 所有不管是什么全部摧毁
            for (var i = 0; i < Content.childCount; i++)
            {
                var child = Content.GetChild(i);
                Object.Destroy(child.gameObject);
            }
        }

        private UIBase GetItemRendererByDic(Transform tsf)
        {
            if (m_ItemTransformDic.TryGetValue(tsf, out var value))
            {
                return value;
            }

            Debug.LogError($"{tsf.name} 没找到这个关联对象 请检查错误");
            return null;
        }

        private void AddItemRendererByDic(Transform tsf, UIBase item)
        {
            if (!m_ItemTransformDic.ContainsKey(tsf))
            {
                m_ItemTransformDic.Add(tsf, item);
            }
        }

        private int GetItemIndex(Transform tsf)
        {
            if (m_ItemTransformIndexDic.TryGetValue(tsf, out var value))
            {
                return value;
            }

            return -1;
        }

        private void ResetItemIndex(Transform tsf, int index)
        {
            if (!m_ItemTransformIndexDic.ContainsKey(tsf))
            {
                m_ItemTransformIndexDic.Add(tsf, index);
            }
            else
            {
                m_ItemTransformIndexDic[tsf] = index;
            }
        }

        #endregion

        #region LoopScrollRect Interface

        private UIBase OnCreateItemRenderer(Type type)
        {
            var uiBase = YIUIFactory.Instantiate(ItemPrefabs, m_BindVos[type]);
            AddItemRendererByDic(uiBase.OwnerRectTransform, uiBase);
            return AddOnClickEvent(uiBase);
        }

        public GameObject GetObject(int index)
        {
            var data = m_Data[index];
            var count = _pool.Count;
            for (var i = 0; i < count; i++)
            {
                var uiBase = _pool[i];
                if (uiBase.OnUser(data, index))
                {
                    var type = uiBase.GetType();
                    var value = m_UIBasePools[type].Get();
                    return value.OwnerGameObject;
                }
            }

            return null;
        }

        public void ReturnObject(Transform transform)
        {
            var uiBase = GetItemRendererByDic(transform);
            if (uiBase == null) return;
            var type = uiBase.GetType();
            m_UIBasePools[type].Put(uiBase);
            ResetItemIndex(transform, -1);
            transform.SetParent(m_Owner.u_CacheRect, false);
        }

        public void ProvideData(Transform transform, int index)
        {
            var uiBase = GetItemRendererByDic(transform);
            if (uiBase == null) return;
            ResetItemIndex(transform, index);
            var select = m_OnClickItemHashSet.Contains(index);
            if (m_Data == null)
            {
                Debug.LogError($"当前没有设定数据 m_Data == null");
                return;
            }

            m_ItemRenderer?.Invoke(index, m_Data[index], uiBase, select);
        }

        #endregion
    }
}