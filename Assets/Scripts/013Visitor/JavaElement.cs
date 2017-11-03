using UnityEngine;
using System.Collections;

public class JavaElement : Element
{

    public JavaElement(string name)
        : base(name)
    {

    }

    public override void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }
}
