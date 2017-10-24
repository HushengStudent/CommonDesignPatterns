using UnityEngine;
using System.Collections;

/// <summary>
/// 单例模式
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> where T :class ,new()
{

    protected static T instance = null;

    public static T Instance
    {
        get
        {
            if (null == instance)
            {
                instance = new T();
            }
            return instance;
        }
    }

    protected Singleton()
    {
        if (instance != null)
        {
            Debug.LogWarning("This " + (typeof(T)).ToString() + " Singleton Instance is not null!");
        }
    }

    public virtual void Init() { }  

}
