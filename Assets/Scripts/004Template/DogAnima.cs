using UnityEngine;
using System.Collections;

public class DogAnima : AbsAnima
{
    public override void PalyVoice()
    {
        base.PalyVoice();
        Debug.LogError("=====>汪!");
    }
}
