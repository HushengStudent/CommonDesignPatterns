using UnityEngine;
using System.Collections;

public class LuaElement : Element
{
    public LuaElement(string name)
        : base(name)
    {

    }

    public override void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }
}
