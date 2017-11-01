using UnityEngine;
using System.Collections;

public class FindState : AbsState {

    public override void Handle(AbsContext context)
    {
        Debug.LogError("=====>Find!");
        context.state = new AttkState();
    }
}
