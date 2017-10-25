using UnityEngine;
using System.Collections;

public class BenzCarMaker : AbsCarMaker
{
    public CarCustomer customer;

    public BenzCarMaker(CarCustomer customer)
    {
        this.customer = customer;
    }

    public override void CreateCar()
    {
        Debug.LogError("=====>Create Benz for "+customer.name+" !");
    }

    public override void SellCar()
    {
        Debug.LogError("=====>Sell Benz to " + customer.name + " !");
    }
}
