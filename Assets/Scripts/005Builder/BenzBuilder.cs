using UnityEngine;
using System.Collections;

public class BenzBuilder : CarBuilder 
{

    public override void CreateTire()
    {
        Debug.LogError("=====>BenzTire");
    }

    public override void CreateSteeringWheel()
    {
        Debug.LogError("=====>BenzSteeringWheel");
    }

    public override void CreateUnderpan()
    {
        Debug.LogError("=====>BenzUnderpan");
    }

}
