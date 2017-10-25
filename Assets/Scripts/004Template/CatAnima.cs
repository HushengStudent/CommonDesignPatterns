using UnityEngine;
using System.Collections;

public class CatAnima : AbsAnima
{

    public override void PalyVoice()
    {
        base.PalyVoice();
        Debug.LogError("=====>喵!");
    }
}
