using UnityEngine;
using System.Collections;

public class TVEquipment : AbsEquipment
{
    public TVEquipment()
    {
        Name = "==TV==";
    }

    public override void TurnOn()
    {
        Debug.LogError(Name + "=====>TurnOn!");
    }

    public override void TurnOff()
    {
        Debug.LogError(Name + "=====>TurnOff!");
    }
}
