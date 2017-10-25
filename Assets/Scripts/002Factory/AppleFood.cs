using UnityEngine;
using System.Collections;

public class AppleFood : Food
{
    public AppleFood(string name)
    {
        SetName(name);
    }

    public override void SetName(string name)
    {
        base.SetName(name); 
    }
}
