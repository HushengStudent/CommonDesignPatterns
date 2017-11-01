using UnityEngine;
using System.Collections;

public class CarEquipment : AbsEquipment
{

    public CarEquipment()
    {
        Name = "==Car==";
    }

    public override void TurnOn()
    {
        Debug.LogError(Name+"=====>TurnOn!");
    }

    public override void TurnOff()
    {
        Debug.LogError(Name + "=====>TurnOff!");
    }
}
