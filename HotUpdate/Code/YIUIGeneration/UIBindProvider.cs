using YIUIFramework;

namespace YIUICodeGenerated
{
    /// <summary>
    /// 由YIUI工具自动创建 请勿手动修改
    /// 用法: UIBindHelper.InternalGameGetUIBindVoFunc = YIUICodeGenerated.UIBindProvider.Get;
    /// </summary>
    public static class UIBindProvider
    {
        public static UIBindVo[] Get()
        {
            var BasePanel     = typeof(BasePanel);
            var BaseView      = typeof(BaseView);
            var BaseComponent = typeof(BaseComponent);
            var list          = new UIBindVo[1];
            list[0] = new UIBindVo
            {
                PkgName     = YIUI.Login.LoginPanelBase.PkgName,
                ResName     = YIUI.Login.LoginPanelBase.ResName,
                CodeType    = BasePanel,
                BaseType    = typeof(YIUI.Login.LoginPanelBase),
                CreatorType = typeof(YIUI.Login.LoginPanel),
            };

            return list;
        }
    }
}