using UnityEngine;
using System.Collections;

public class NPCContext : AbsContext
{
    public NPCContext()
    {
        base.state = new FindState();
    }

    public override void Excute()
    {
        state.Handle(this);
    }
}
