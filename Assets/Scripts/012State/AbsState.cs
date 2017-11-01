using UnityEngine;
using System.Collections;

public abstract class AbsState
{

    public abstract void Handle(AbsContext context);
}
