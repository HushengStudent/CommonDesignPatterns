using UnityEngine;
using System.Collections;

public class DeathState : AbsState {

    public override void Handle(AbsContext context)
    {
        Debug.LogError("=====>Death!");
        Debug.LogError("=====>Game Over!");
    }
}
