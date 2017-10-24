using UnityEngine;
using System.Collections;

public class HondaFactory : AbsCarFactory
{
    public override AbsCar CreateCar()
    {
        return new HondaCar();
    }
}
