using UnityEngine;
using System.Collections;

/// <summary>
/// 中介者模式
/// </summary>
public abstract class AbsMediator 
{
    public abstract void Send(string message, AbsCountry country);
}
