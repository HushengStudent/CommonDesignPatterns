using UnityEngine;
using System.Collections;

public class Decorator : ICloth {


    public Decorator(Person person,ICloth cloth)
    {
        this.person = person;
        this.cloth = cloth;
    }

    public Person person;

    public ICloth cloth;

    public virtual void Operation()
    {
        cloth.Operation();
    }
}
