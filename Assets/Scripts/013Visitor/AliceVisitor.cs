using UnityEngine;
using System.Collections;

public class AliceVisitor : Visitor
{
    public AliceVisitor(string name)
        : base(name)
    {

    }

    public override void Visit(Element element)
    {
        Debug.LogError(element.Name + "=====>" + Name);
    }
}
