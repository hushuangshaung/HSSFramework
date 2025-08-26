using UnityEngine;

public interface IManager
{
    bool IsInitialized();
    void Initialize();
    void Initialized();
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
    private bool _isInitialized;
    
    public bool IsInitialized()
    {
        return _isInitialized;
    }
    
    void IManager.Initialize()
    {
        if (_isInitialized)
        {
            Debug.LogError($"{typeof(T)} Initialized");
            return;
        }
        
        OnInitialize();
    }
    
    void IManager.Initialized()
    {
        OnInitialized();
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
        _isInitialized = true;
    }
    
    /// <summary>
    /// 所有OnInitialize()执行完之后执行，游戏只执行一次
    /// </summary>
    protected virtual void OnInitialized()
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