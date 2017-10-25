using UnityEngine;
using System.Collections;

/// <summary>
/// 建造者模式
/// </summary>
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
