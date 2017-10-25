using UnityEngine;
using System.Collections;

public class Test3 : MonoBehaviour
{
    AbsCar car;

	// Use this for initialization
	void Start () 
    {
        Test();
	}

    private void Test()
    {
        car = CarUtil.CreateCar(CarType.Benz);
        if (car != null) car.PrintName();
        car = CarUtil.CreateCar(CarType.Bmw);
        if (car != null) car.PrintName();
        car = CarUtil.CreateCar(CarType.Honda);
        if (car != null) car.PrintName();
    }
	
}
