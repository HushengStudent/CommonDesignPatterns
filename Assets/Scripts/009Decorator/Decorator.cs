using UnityEngine;
using System.Collections;

/// <summary>
/// 装饰者模式
/// </summary>
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
