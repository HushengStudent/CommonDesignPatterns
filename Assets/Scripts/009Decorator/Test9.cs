using UnityEngine;
using System.Collections;

public class Test9 : MonoBehaviour {

    Person person = new Person("Tom");

    void Start()
    {
        Test();
    }

    private void Test()
    {
        CoatDecorator decorator = new CoatDecorator(person);
        decorator.Operation();
        SkirtDecorator decorator2 = new SkirtDecorator(person);
        decorator2.Operation();
    }
}
