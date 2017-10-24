using UnityEngine;
using System.Collections;

public class BenzFactory : AbsCarFactory
{
    public override AbsCar CreateCar()
    {
        return new BenzCar();
    }
}
