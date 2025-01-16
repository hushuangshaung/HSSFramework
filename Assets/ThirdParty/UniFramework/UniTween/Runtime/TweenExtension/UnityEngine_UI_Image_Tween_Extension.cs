using System;
using UniFramework.Tween;

namespace UnityEngine.UI
{
    public static class UnityEngine_UI_Image_Tween_Extension
    {
        public static ColorTween TweenColor(this Image obj, float duration, Color from, Color to)
        {
            ColorTween node = ColorTween.Allocate(duration, from, to);
            node.SetOnUpdate((result) => { obj.color = result; });
            return node;
        }
        public static ColorTween TweenColorTo(this Image obj, float duration, Color to)
        {
            return TweenColor(obj, duration, obj.color, to);
        }
        public static ColorTween TweenColorFrom(this Image obj, float duration, Color from)
        {
            return TweenColor(obj, duration, from, obj.color);
        }

        
        public static FloatTween TweenFillAmount(this Image obj, float duration, float from, float to, Action<float> callBack = null)
        {
            FloatTween node = FloatTween.Allocate(duration, from, to);
            node.SetOnUpdate((result) => { obj.fillAmount = result; callBack?.Invoke(result);});
            return node;
        }
        public static FloatTween TweenColorTo(this Image obj, float duration, float to, Action<float> callBack = null)
        {
            return TweenFillAmount(obj, duration, obj.fillAmount, to);
        }
        public static FloatTween TweenColorFrom(this Image obj, float duration, float from, Action<float> callBack = null)
        {
            return TweenFillAmount(obj, duration, from, obj.fillAmount);
        }
    }
}
