using System.Collections.Generic;
using UnityEngine;

namespace YIUIFramework
{
    public static partial class YIUIFactory
    {
        // public static T Instantiate<T>(RectTransform itemRoot, UIBindVo vo, RectTransform parent = null) where T : UIBase
        // {
        //     var transform = itemRoot.FindChildByName(vo.ResName);
        //     if (transform == null)
        //     {
        //         Debug.LogError($"没有加载到这个资源 {vo.PkgName}/{itemRoot}/{vo.ResName}");
        //         return null;
        //     }
        //
        //     var newObj = Object.Instantiate(transform);
        //     var instance = (T)CreateByObjVo(vo, newObj.gameObject);
        //
        //     SetParent(instance.OwnerRectTransform, parent ? parent : PanelMgr.Inst.UICache);
        //
        //     return instance;
        // }
        
        public static T Instantiate<T>(GameObject itemPrefab, UIBindVo vo, RectTransform parent = null) where T : UIBase
        {
            if (itemPrefab == null)
            {
                Debug.LogError($"没有加载到这个资源 {vo.PkgName}/{vo.ResName}");
                return null;
            }

            var newObj = Object.Instantiate(itemPrefab);
            var instance = (T)CreateByObjVo(vo, newObj);

            SetParent(instance.OwnerRectTransform, parent ? parent : PanelMgr.Inst.UICache);

            return instance;
        }

        public static UIBase Instantiate(List<GameObject> itemPrefabs, UIBindVo vo, RectTransform parent = null)
        {
            if (itemPrefabs.Count == 0)
            {
                Debug.LogError($"没有加载到这个资源 {vo.PkgName}/{vo.ResName}");
                return null;
            }
            GameObject prefab = null;
            foreach (var itemPrefab in itemPrefabs)
            {
                if (itemPrefab.name == vo.ResName)
                {
                    prefab = itemPrefab;
                    break;
                }
            }
            var newObj = Object.Instantiate(prefab);
            var instance = CreateByObjVo(vo, newObj);
            SetParent(instance.OwnerRectTransform, parent ? parent : PanelMgr.Inst.UICache);
            return instance;
        }
    }
}