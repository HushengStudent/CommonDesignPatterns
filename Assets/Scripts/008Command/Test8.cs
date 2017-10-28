using UnityEngine;
using System.Collections;

public class Test8 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Receiver receiver = new Receiver();
        AbsCommand command = new AppleCommand(receiver);
        Invoker invoker = new Invoker();
        invoker.SendCommand(command);
        invoker.ExecuteCommand();
        command = new StrawberryCommand(receiver);
        invoker.SendCommand(command);
        invoker.ExecuteCommand();
	}
	
}
