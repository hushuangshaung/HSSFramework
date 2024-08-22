namespace UnityEngine
{
    public static class Log
    {
        private static readonly bool _isPrint = true;
        public static void Print(object message)
        {
            if (!_isPrint)
            {
                return;
            }

            Debug.Log(message);
        }

        public static void Warn(object message)
        {
            if (!_isPrint)
            {
                return;
            }
        
            Debug.LogWarning(message);
        }

        public static void Error(object message)
        {
            if (!_isPrint)
            {
                return;
            }
        
            Debug.LogError(message);
        }
    }
}