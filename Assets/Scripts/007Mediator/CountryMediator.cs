using UnityEngine;
using System.Collections;

public class CountryMediator : AbsMediator
{
    public override void Send(string message, AbsCountry country)
    {
        Debug.LogError(country.name + ":" + message);
    }
}
