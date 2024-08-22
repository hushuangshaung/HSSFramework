namespace UnityEngine
{
    public static class UnityEngine_GameObject_Extension
    {
        public static T AddMissingComponent<T>(this GameObject obj) where T : Component
        {
            var component = obj.GetComponent<T>();
            if (component == null)
            {
                component = obj.AddComponent<T>();
            }
            return component;
        }
    }
}