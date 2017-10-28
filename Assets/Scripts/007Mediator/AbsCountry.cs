using UnityEngine;
using System.Collections;

public abstract class AbsCountry 
{
    protected AbsMediator mediator;

    public string name;

    public AbsCountry(AbsMediator mediator,string name)
    {
        this.mediator = mediator;
        this.name = name;
    }
}
