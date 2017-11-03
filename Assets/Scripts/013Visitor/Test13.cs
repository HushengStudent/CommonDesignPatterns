using UnityEngine;
using System.Collections;

public class Test13 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Test();
	}

    public void Test()
    {
        JavaElement java = new JavaElement("Java");
        LuaElement lua = new LuaElement("Lua");

        TomVisitor tom = new TomVisitor("Tom");
        AliceVisitor alice = new AliceVisitor("Alice");

        java.Accept(tom);
        java.Accept(alice);

        lua.Accept(tom);
        lua.Accept(alice);
    }
}
