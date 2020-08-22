using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDatabase : MonoBehaviour
{
    public CharacterStats myPlayer;
    public int GLOBALnumberOfSlots;
    public List<Item> foods = new List<Item>();  //List of foods

    void Awake()
    {
        //builddatabase way before start, so all the values for inventory size is known
        BuildItemDatabase();
        Debug.Log("food eaten awake" + myPlayer.foodEaten);

    }

    void Update()
    {
        Debug.Log("food eaten update" + myPlayer.foodEaten);
    }


    /*------------------------------------------------------------------------------------
  //---------------------------------SEARCH FOR FOOD----------------------------------
  /------------------------------------------------------------------------------------*/
    /*loops through every item on food list with id
     *compare the food to every every food in database
     *return back if we found it
     */

    public Item GetItem(int id)
    {
        return foods.Find(foods => foods.id == id);
    }

    public Item GetItem(string title)
    {
        return foods.Find(foods => foods.title == title);
    }

    /*------------------------------------------------------------------------------------
    //---------------------------------DATABASE FOR foods----------------------------------
    /------------------------------------------------------------------------------------*/

    void BuildItemDatabase()
    {
        //create a new list and populate with items
        //to check what is in an item: items[0].stats["Power"].ToString();
        foods = new List<Item>()
        {
            new Item(1, "Banana", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 15 },
                {"Happiness", 5 },
                {"Cost", 10 }
            }),
            new Item(2, "Banana", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 10 },
                {"Happiness", 10 },
                {"Cost", 5 }
            }),
            new Item(3, "Coconut", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 20 },
                {"Happiness", 10 },
                {"Cost", 35 }

            }),
            new Item(4, "Pineapple", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 25 },
                {"Happiness", 15 },
                {"Cost", 15 }
            }),
            new Item(5, "Tomato", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 10 },
                {"Happiness", 5 },
                {"Cost", 5 }
            }),
            new Item(5, "WaterMelon", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 20 },
                {"Happiness", 20 },
                {"Cost", 40 }
            }),
        };


        //the amount of slots needed to show in the UI
        //GLOBALnumberOfSlots = foods.Count;
    }
}
