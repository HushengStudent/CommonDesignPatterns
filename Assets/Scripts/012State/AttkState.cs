using UnityEngine;
using System.Collections;

public class AttkState : AbsState {

    public override void Handle(AbsContext context)
    {
        Debug.LogError("=====>Attk!");
        context.state = new DeathState();
    }
}
