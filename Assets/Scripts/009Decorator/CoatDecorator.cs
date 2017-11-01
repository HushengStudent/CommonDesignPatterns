using UnityEngine;
using System.Collections;

public class CoatDecorator : Decorator
{
    public CoatDecorator(Person person)
        : base(person, new CoatCloth())
    {
    }
}
