using UnityEngine;
using System.Collections;

public class Food 
{

    public string Name;

    public void Excute()
    {
        Debug.Log("=====>" + Name);
    }

    public virtual void SetName(string name)
    {
        Name = name;
    }
}
