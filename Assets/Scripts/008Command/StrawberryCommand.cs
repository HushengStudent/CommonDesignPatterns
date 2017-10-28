using UnityEngine;
using System.Collections;

public class StrawberryCommand : AbsCommand
{
    public StrawberryCommand(Receiver receiver)
        : base(receiver)
    {

    }

    public override void Execute()
    {
        receiver.Action();
        Debug.LogError("=====>StrawberryCommand Execute!");
    }
}
