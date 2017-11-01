using UnityEngine;
using System.Collections;

public abstract class AbsEquipment 
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public abstract void TurnOn();

    public abstract void TurnOff();
}
