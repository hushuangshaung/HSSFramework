﻿using System;
using YIUIBind;
using YIUIFramework;
using UnityEngine;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using YIUI.Login;

public static partial class Two
{
    public static void OpenLoginPanel()
    {
        PanelMgr.Inst.OpenPanel<LoginPanel>();
    }
}

namespace YIUI.Login
{
    /// <summary>
    /// Author  YIUI
    /// Date    2024.8.22
    /// </summary>
    public sealed partial class LoginPanel:LoginPanelBase
    {
    
        #region 生命周期
        
        protected override void Initialize()
        {
            Debug.Log($"LoginPanel Initialize");
        }

        protected override void Start()
        {
            Debug.Log($"LoginPanel Start");
        }

        protected override void OnEnable()
        {
            Debug.Log($"LoginPanel OnEnable");
        }

        protected override void OnDisable()
        {
            Debug.Log($"LoginPanel OnDisable");
        }

        protected override void OnDestroy()
        {
            Debug.Log($"LoginPanel OnDestroy");
        }

        protected override async UniTask<bool> OnOpen()
        {
            await UniTask.CompletedTask;
            Debug.Log($"LoginPanel OnOpen");
            return true;
        }

        protected override async UniTask<bool> OnOpen(ParamVo param)
        {
            return await base.OnOpen(param);
        }
        
        #endregion

        #region Event开始


       
        protected override void OnEventStartAction()
        {
            Log.Error("开始");
        }
        #endregion Event结束

    }
}