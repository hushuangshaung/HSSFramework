public interface IManager
{
    void Initialize();
    void SignIn();
    void SignOut();
    void Destroy();
}

public class Singleton<T> where T : Singleton<T>, new()
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            return _instance ??= new T();
        }
        protected set => _instance = value;
    }
}

public class Manager<T> : Singleton<T>, IManager where T : Manager<T>, new()
{
    void IManager.Initialize()
    {
        OnInitialize();
    }

    void IManager.SignIn()
    {
        OnSignIn();
    }

    void IManager.SignOut()
    {
        OnSignOut();
    }

    void IManager.Destroy()
    {
        OnDestroy();
    }

    /// <summary>
    /// 初始化，游戏只执行一次
    /// </summary>
    protected virtual void OnInitialize()
    {
    }
    
    /// <summary>
    /// 每次登录执行
    /// </summary>
    protected virtual void OnSignIn()
    {
    }
    
    /// <summary>
    /// 每次登出执行
    /// </summary>
    protected virtual void OnSignOut()
    {
        
    }
    
    /// <summary>
    /// 销毁时执行
    /// </summary>
    protected virtual void OnDestroy()
    {
        
    }
}