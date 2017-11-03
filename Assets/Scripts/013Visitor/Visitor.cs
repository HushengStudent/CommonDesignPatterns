using UnityEngine;
using System.Collections;

public abstract class Visitor  {

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Visitor(string name)
    {
        this.name = name;
    }

    public abstract void Visit(Element element);
}
