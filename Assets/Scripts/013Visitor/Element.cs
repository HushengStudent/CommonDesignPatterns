using UnityEngine;
using System.Collections;

public abstract class Element
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Element(string name)
    {
        this.name = name;
    }

    public abstract void Accept(Visitor visitor);
}
