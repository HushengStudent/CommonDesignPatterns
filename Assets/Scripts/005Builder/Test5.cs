using UnityEngine;
using System.Collections;

public class Test5 : MonoBehaviour {

    CarBuilder builder;

    CarDirector director;

	// Use this for initialization
	void Start ()
    {
        Test();
	}

    public void Test()
    {
        
        builder = new BenzBuilder();
        director = new CarDirector(builder);
        director.CreateCar();

        builder = new BmwBuilder();
        director = new CarDirector(builder);
        director.CreateCar();

        builder = new HondaBuilder();
        director = new CarDirector(builder);
        director.CreateCar();

    }
}
