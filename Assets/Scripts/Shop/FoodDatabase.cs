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

    }

    void Update()
    {
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
            new Item(1, "Apple", "a fruit",
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
        };


        //the amount of slots needed to show in the UI
        //GLOBALnumberOfSlots = foods.Count;
    }
}
