using UnityEngine;
using System.Collections;

public class AppleCommand : AbsCommand
{
    public AppleCommand(Receiver receiver)
        : base(receiver)
    {

    }

    public override void Execute()
    {
        receiver.Action();
        Debug.LogError("=====>AppleCommand Execute!");
    }
}
