using UnityEngine;

namespace HotUpdate.Code.Kernel.Camera
{
    public class CameraManager: Manager<CameraManager>
    {
        public GameObject FullBackGround { get; private set; }
        public UnityEngine.Camera MainCamera { get; private set; }
        
        /// <summary>
        /// 初始化，游戏只执行一次
        /// </summary>
        protected override void OnInitialize()
        {
            FullBackGround = GameObject.Find("MainCamera/Canvas").gameObject;
            MainCamera = GameObject.Find("MainCamera").GetComponent<UnityEngine.Camera>();
            base.OnInitialize();
        }
        
        /// <summary>
        /// 所有OnInitialize()执行完之后执行，游戏只执行一次
        /// </summary>
        protected override void OnInitialized()
        {
            
        }
        
        /// <summary>
        /// 每次登录执行
        /// </summary>
        protected override void OnSignIn()
        {
            
        }
        
        /// <summary>
        /// 每次登出执行
        /// </summary>
        protected override void OnSignOut()
        {
            
        }
        
        /// <summary>
        /// 销毁时执行
        /// </summary>
        protected override void OnDestroy()
        {

        }
        
        public void FullBackGroundSetActive(bool value)
        {
            FullBackGround.SetActive(value);
        }
    }
}