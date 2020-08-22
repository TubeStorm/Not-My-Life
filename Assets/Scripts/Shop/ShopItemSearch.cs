using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ShopItemSearch : MonoBehaviour
{
    //save values from purchase
    public static ShopItemSearch instance;
    static protected float energy;
    public bool pressed = true;

    void Start()
	{
        instance = this;
	}

    public void findFoodCost()
	{

        string name = EventSystem.current.currentSelectedGameObject.name;
        int price;
        price = foodToFind(name);
        //price = junkToFind(name);

        Debug.Log(name + "   costs: $" + price);

    }


    private int foodToFind(string name)
	{

        int price = 0;
        switch (name)
        {
            case "Avocado":
                price = 5;
                CharacterStats.SetEnergy(5);
                CharacterStats.SetMoney(-1 * price);
                break;
            case "Banana":
                price = 5;
                break;
            case "Apple":
                price = 5;
                break;
            case "Coconut":
                price = 10;
                break;
            case "Mushroom":
                price = 15;
                break;
            case "Onion":
                price = 5;
                break;
            case "Pepper":
                price = 5;
                break;
            case "Pineapple":
                price = 10;
                break;
            case "Salad":
                price = 5;
                break;
            case "SweetPepper":
                price = 5;
                break;
            case "Tomato":
                price = 5;
                break;
            case "Watermelon":
                price = 10;
                break;
        }

        return price;
    }

    private int junkToFind(string name)
    {
        int price = 0;
        switch (name)
        {
            case "Baguette":
                price = 5;
                break;
            case "Burger":
                price = 5;
                break;
            case "Cheese":
                price = 5;
                break;
            case "Cheese Slice":
                price = 10;
                break;
            case "Chicken":
                price = 15;
                break;
            case "Hotdog":
                price = 5;
                break;
        }

        return price;
    }

    public static float GetEnergy()
    {
        return energy;
    }

  

}
