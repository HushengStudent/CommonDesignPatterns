using UnityEngine;
using System.Collections;

public class Test6 : MonoBehaviour {

    AbsCarMaker carMaker;

	void Start () 
    {
        Test();
	}
	
	private void Test () 
    {
        CarCustomer customer = new CarCustomer("Tom");

        CarProxy proxy = new CarProxy(customer, CarProxyType.Benz);
        proxy.CreateCar();
        proxy.SellCar();

        proxy = new CarProxy(customer, CarProxyType.Bmw);
        proxy.CreateCar();
        proxy.SellCar();

	}
}
