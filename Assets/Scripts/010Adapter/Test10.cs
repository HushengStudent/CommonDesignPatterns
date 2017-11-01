using UnityEngine;
using System.Collections;

public class Test10 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Test();
	}

    private void Test()
    {
        AbsEquipment equipment = new CarEquipment();
        equipment.TurnOn();
        equipment.TurnOff();
        equipment = new TVEquipment();
        equipment.TurnOn();
        equipment.TurnOff();
        equipment = new BookAdapter(new Book());
        equipment.TurnOn();
        equipment.TurnOff();
    }
}
