using UnityEngine;
using System.Collections;

public class BmwBuilder : CarBuilder
{

    public override void CreateTire()
    {
        Debug.LogError("=====>BmwTire");
    }

    public override void CreateSteeringWheel()
    {
        Debug.LogError("=====>BmwSteeringWheel");
    }

    public override void CreateUnderpan()
    {
        Debug.LogError("=====>BmwUnderpan");
    }

}
