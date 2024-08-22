using System;
using YIUIBind;
using YIUIFramework;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace YIUI.Login
{



    /// <summary>
    /// 由YIUI工具自动创建 请勿手动修改
    /// </summary>
    public abstract class LoginPanelBase:BasePanel
    {
        public const string PkgName = "Login";
        public const string ResName = "LoginPanel";
        
        public override EWindowOption WindowOption => EWindowOption.BanTween;
        public override EPanelLayer Layer => EPanelLayer.Panel;
        public override EPanelOption PanelOption => EPanelOption.None;
        public override EPanelStackOption StackOption => EPanelStackOption.Visible;
        public override int Priority => 0;
        protected UIEventP0 u_EventStart { get; private set; }
        protected UIEventHandleP0 u_EventStartHandle { get; private set; }

        
        protected sealed override void UIBind()
        {
            u_EventStart = EventTable.FindEvent<UIEventP0>("u_EventStart");
            u_EventStartHandle = u_EventStart.Add(OnEventStartAction);

        }

        protected sealed override void UnUIBind()
        {
            u_EventStart.Remove(u_EventStartHandle);

        }
     
        protected virtual void OnEventStartAction(){}
   
   
    }
}