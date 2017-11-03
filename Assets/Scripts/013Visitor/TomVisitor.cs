using UnityEngine;
using System.Collections;

public class TomVisitor : Visitor {

    public TomVisitor(string name)
        : base(name)
    {

    }

    public override void Visit(Element element)
    {
        Debug.LogError(element.Name + "=====>" + Name);
    }
}
