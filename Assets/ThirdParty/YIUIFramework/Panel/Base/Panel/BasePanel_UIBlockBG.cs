using UnityEngine;

namespace YIUIFramework
{
    public partial class BasePanel
    {
        private GameObject m_uiblockBGObj;
        public GameObject UIBlockBGObj {
            get
            {
                if (m_uiblockBGObj == null)
                {
                    m_uiblockBGObj = OwnerGameObject.transform.FindChildByName("UIBlockBG").gameObject;
                }

                return m_uiblockBGObj;
            }
        }
    }
}