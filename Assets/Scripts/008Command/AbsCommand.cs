using UnityEngine;
using System.Collections;

public abstract class AbsCommand 
{
    protected Receiver receiver;

    public AbsCommand(Receiver receiver)
    {
        this.receiver = receiver;
    }

    public abstract void Execute();
}
