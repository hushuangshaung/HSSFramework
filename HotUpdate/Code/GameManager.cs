using System;
using System.Collections;
using UnityEngine;

public static class GameManager
{
    #region behaviour
    private static MonoBehaviour _behaviour;
    public static void SetMonoBehaviour(MonoBehaviour behaviour)
    {
        _behaviour = behaviour;
    }
    
    /// <summary>
    /// 开启一个协程
    /// </summary>
    public static void StartCoroutine(IEnumerator enumerator)
    {
        _behaviour.StartCoroutine(enumerator);
    }
    /// <summary>
    /// 关闭一个协程
    /// </summary>
    /// <param name="enumerator"></param>
    public static void StopCoroutine(IEnumerator enumerator)
    {
        _behaviour.StopCoroutine(enumerator);
    }

    public static void StopAllCoroutines()
    {
        _behaviour.StopAllCoroutines();
    }
    #endregion
    
    #region register tick fixtedTick lateTick
    private static Action<float> _tick;
    private static Action<float> _fixedTick;
    private static Action<float> _lateTick;

    public static void Update(float deltaTime)
    {
        _tick?.Invoke(deltaTime);
    }

    public static void FixedUpdate(float fixedTime)
    {
        _fixedTick?.Invoke(fixedTime);
    }

    public static void LateUpdate(float deltaTime)
    {
        _lateTick?.Invoke(deltaTime);
    }
    
    public static void RegisterTick(Action<float> tick)
    {
        _tick += tick;
    }
    public static void UnRegisterTick(Action<float> tick)
    {
        _tick -= tick;
    }
    
    public static void RegisterFixedTick(Action<float> tick)
    {
        _fixedTick += tick;
    }
    public static void UnRegisterFixedTick(Action<float> tick)
    {
        _fixedTick -= tick;
    }
    
    public static void RegisterLateTick(Action<float> tick)
    {
        _lateTick += tick;
    }
    public static void UnRegisterLateTick(Action<float> tick)
    {
        _lateTick -= tick;
    }

    public static void UnRegisterAllTick()
    {
        _tick = null;
        _fixedTick = null;
        _lateTick = null;
    }
    #endregion
}