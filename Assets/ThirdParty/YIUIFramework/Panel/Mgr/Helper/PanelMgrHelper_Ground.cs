using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YIUIFramework
{
    public static partial class PanelMgrHelper
    {
        private static GameObject m_PopupUIGround;
        private static RectTransform m_PopupUIGroundRect;
        
        public static void InitAddPopupUIGround()
        {
            m_PopupUIGround = new GameObject("PopupUIGround");
            var image = m_PopupUIGround.AddComponent<Image>();
            image.color = new Color(0, 0, 0, 0.5f);
            m_PopupUIGroundRect = m_PopupUIGround.GetComponent<RectTransform>();
            m_PopupUIGroundRect.SetParent(PanelMgr.Inst.UILayerRoot);
            m_PopupUIGroundRect.anchoredPosition3D = Vector3.zero;
            m_PopupUIGroundRect.localScale = Vector3.one;
            m_PopupUIGroundRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (int)(Screen.width * 1.26f));
            m_PopupUIGroundRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (int)(Screen.height * 1.26f));
            SetPopupUIGround(false);
        }
        
        public static void FreshGround(List<PanelInfo> layerList)
        {
            if (layerList == null)
            {
                return;
            }
        
            bool isShowGround = false;
            var count = layerList.Count;
            for (var i = count - 1; i >= 0; i--)
            {
                var info = layerList[i];
                if (info.UIBasePanel != null && info.UIBasePanel.IsShowGround)
                {
                    isShowGround = true;
                    
                    m_PopupUIGroundRect.SetParent(info.UIBasePanel.UIBlockBGObj.transform);
                    m_PopupUIGroundRect.anchoredPosition3D = Vector3.zero;
                    m_PopupUIGroundRect.localScale = Vector3.one;
                    SetPopupUIGround(true);
                    break;
                }
            }
        
            if (!isShowGround)
            {
                //移出
                m_PopupUIGroundRect.SetParent(PanelMgr.Inst.UILayerRoot);
                SetPopupUIGround(false);
            }
        }
        
        /// <summary>
        /// 设置UI是否有黑底
        /// 不能提供此API对外操作
        /// 因为有人设置过后就会忘记恢复
        /// </summary>
        /// <param name="value">true = 显示</param>
        private static void SetPopupUIGround(bool value)
        {
            m_PopupUIGround.SetActive(value);
        }
    }
}