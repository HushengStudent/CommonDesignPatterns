using UnityEngine;
using System.Collections;

public class SkirtDecorator : Decorator {

    public SkirtDecorator(Person person)
        : base(person, new SkirtCloth())
    {

    }
}
