using UnityEngine;
using System.Collections;

public class Person  {

    public Person(string name)
    {
        this.name = name;
    }

    private string name;

    public string Name
    {
        get
        {
            return name;
        }
    }
}
