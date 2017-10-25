using UnityEngine;
using System.Collections;

public class HondaBuilder : CarBuilder
{

    public override void CreateTire()
    {
        Debug.LogError("=====>HondaTire");
    }

    public override void CreateSteeringWheel()
    {
        Debug.LogError("=====>HondaSteeringWheel");
    }

    public override void CreateUnderpan()
    {
        Debug.LogError("=====>HondaUnderpan");
    }
}
