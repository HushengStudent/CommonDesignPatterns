using UnityEngine;
using System.Collections;

/// <summary>
/// 代理模式
/// </summary>
public class CarProxy : ICar
{
    AbsCarMaker carMaker;

    public CarProxy(CarCustomer customer, CarProxyType type)
    {
        if (type == CarProxyType.Benz)
        {
            carMaker = new BenzCarMaker(customer);
        }
        if (type == CarProxyType.Bmw)
        {
            carMaker = new BmwCarMaker(customer);
        }
    }

    public void CreateCar()
    {
        carMaker.CreateCar();
    }

    public void SellCar()
    {
        carMaker.SellCar();
    }
	
}

public enum CarProxyType
{
    Benz,
    Bmw,
}
