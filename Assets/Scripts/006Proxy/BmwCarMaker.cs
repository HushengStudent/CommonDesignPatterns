using UnityEngine;
using System.Collections;

public class BmwCarMaker : AbsCarMaker
{
    public CarCustomer customer;

    public BmwCarMaker(CarCustomer customer)
    {
        this.customer = customer;
    }

    public override void CreateCar()
    {
        Debug.LogError("=====>Create Bmw for " + customer.name + " !");
    }

    public override void SellCar()
    {
        Debug.LogError("=====>Sell Bmw to " + customer.name + " !");
    }
}
