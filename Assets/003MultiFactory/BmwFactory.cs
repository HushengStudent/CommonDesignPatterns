using UnityEngine;
using System.Collections;

public class BmwFactory : AbsCarFactory
{
    public override AbsCar CreateCar()
    {
        return new BmwCar();
    }
}
