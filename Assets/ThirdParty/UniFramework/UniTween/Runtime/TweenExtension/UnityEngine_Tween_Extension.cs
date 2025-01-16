using UniFramework.Tween;

namespace UnityEngine
{
    public static class UnityEngine_Tween_Extension
    {
        public static TweenHandle Play(this QuaternionTween obj)
        {
            return UniTween.Play(obj);
        }
        
        public static TweenHandle Play(this ColorTween obj)
        {
            return UniTween.Play(obj);
        }
        
        public static TweenHandle Play(this Vector4Tween obj)
        {
            return UniTween.Play(obj);
        }
        
        public static TweenHandle Play(this Vector3Tween obj)
        {
            return UniTween.Play(obj);
        }
        
        public static TweenHandle Play(this Vector2Tween obj)
        {
            return UniTween.Play(obj);
        }
            
        public static TweenHandle Play(this FloatTween obj)
        {
            return UniTween.Play(obj);
        }
    }
}