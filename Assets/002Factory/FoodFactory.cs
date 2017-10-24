using UnityEngine;
using System.Collections;

public static class FoodFactory 
{
    public static Food CreateFood(FoodType type)
    {
        Food target = null;
        switch (type)
        {
            case FoodType.Apple:
                target = new AppleFood("apple");
                break;
            case FoodType.StrawberryFood:
                target = new StrawberryFood("strawberry");
                break;
            default:
                break;
        }
        return target;
    }
	
}

public enum FoodType
{
    Apple,
    StrawberryFood
}
