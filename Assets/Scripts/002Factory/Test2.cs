using UnityEngine;
using System.Collections;

public class Test2:MonoBehaviour
{
    Food food;

    void Start()
    {
        Test();
    }

    public void Test()
    {
        food = FoodFactory.CreateFood(FoodType.Apple);
        if (food != null)
        {
            food.Excute();
        }
        food = FoodFactory.CreateFood(FoodType.StrawberryFood);
        if (food != null)
        {
            food.Excute();
        }
    }
}
