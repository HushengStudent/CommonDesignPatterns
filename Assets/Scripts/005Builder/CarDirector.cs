using UnityEngine;
using System.Collections;

public class CarDirector 
{
    private CarBuilder builder;

    public CarDirector(CarBuilder builder)
    {
        this.builder = builder;
    }

    public void CreateCar()
    {
        builder.CreateTire();
        builder.CreateSteeringWheel();
        builder.CreateUnderpan();
        Debug.LogError("=====>Finished!");
    }

}
