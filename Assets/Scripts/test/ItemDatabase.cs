using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();  //List of foods


    void Awake()
    {
        BuildDatabase();

    }


    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }



    void BuildDatabase()
    {
        items = new List<Item>()
        {
            new Item(1, "armor", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 15 },
                {"Happiness", 5 },
                {"Cost", 10 }
            }),
            new Item(2, "axe", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 10 },
                {"Happiness", 10 },
                {"Cost", 5 }
            }),
            new Item(3, "axe2", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 20 },
                {"Happiness", 10 },
                {"Cost", 35 }

            }),
            new Item(4, "axeDouble", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 25 },
                {"Happiness", 15 },
                {"Cost", 15 }
            }),
            new Item(5, "axeDouble2", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 10 },
                {"Happiness", 5 },
                {"Cost", 5 }
            }),
            new Item(5, "backpack", "a fruit",
            new Dictionary<string, int>
            {
                {"Energy", 20 },
                {"Happiness", 20 },
                {"Cost", 40 }
            }),
        };

    }
}
