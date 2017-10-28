using UnityEngine;
using System.Collections;

public abstract class AbsMediator 
{
    public abstract void Send(string message, AbsCountry country);
}
