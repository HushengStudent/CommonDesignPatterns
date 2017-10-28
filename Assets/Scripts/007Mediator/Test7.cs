using UnityEngine;
using System.Collections;

public class Test7 : MonoBehaviour {

    private CountryMediator mediator = new CountryMediator();

    private USACountry usa;

    private UKCountry uk;

	// Use this for initialization
	void Start () {

        usa = new USACountry(mediator);
        mediator.Send("hello uk!", usa);
        uk = new UKCountry(mediator);
        mediator.Send("hello usa!", uk);
	}
	
}
