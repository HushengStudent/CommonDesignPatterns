using UnityEngine;
using System.Collections;

/// <summary>
/// 模板方法模式
/// </summary>
public abstract class AbsAnima  
{
    public virtual void PalyVoice()
    {
        Debug.LogError("=====>开始!");
    }
}
