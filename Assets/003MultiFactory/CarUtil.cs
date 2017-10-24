using UnityEngine;
using System.Collections;

public static class CarUtil 
{
    public static AbsCar CreateCar(CarType type)
    {
        AbsCar target = null;
        AbsCarFactory factory = null;
        switch (type)
        {
            case CarType.Benz:
                factory = new BenzFactory();
                break;
            case CarType.Bmw:
                factory = new BmwFactory();
                break;
            case CarType.Honda:
                factory = new HondaFactory();
                break;
            default:
                break;
        }
        if (null == factory) return null;
        target = factory.CreateCar();
        return target;
    }
	
}

public enum CarType
{
    Benz,
    Bmw,
    Honda
}
