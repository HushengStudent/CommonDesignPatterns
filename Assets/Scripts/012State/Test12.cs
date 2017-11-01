using UnityEngine;
using System.Collections;

public class Test12 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Test();
	}

    private void Test()
    {
        NPCContext context = new NPCContext();
        context.Excute();
        context.Excute();
        context.Excute();
    }
}
