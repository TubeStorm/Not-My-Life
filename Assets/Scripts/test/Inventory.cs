using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;

    private void Start()
    {
        GiveItem("backpack");

        GiveItem(1);
        GiveItem(2);
        GiveItem(3);
        RemoveItem(2);
    }

    void GiveItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }


    public Item CheckForItem(int id)
	{
        return characterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
	{
        Item item = CheckForItem(id);
        if(item != null)
		{
            characterItems.Remove(item);
            Debug.Log("Removed item: " + item.title);

        }
    }

}
