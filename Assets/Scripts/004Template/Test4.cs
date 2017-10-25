using UnityEngine;
using System.Collections;

public class Test4 : MonoBehaviour {

    AbsAnima anima;

    void Start()
    {
        Test();
    }

    public void Test()
    {
        anima = new CatAnima();
        anima.PalyVoice();
        anima = new DogAnima();
        anima.PalyVoice();
    }

}
