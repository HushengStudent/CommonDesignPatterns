using UnityEngine;
using System.Collections;

/// <summary>
/// 命令模式
/// </summary>
public abstract class AbsCommand 
{
    protected Receiver receiver;

    public AbsCommand(Receiver receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Execute();
}
