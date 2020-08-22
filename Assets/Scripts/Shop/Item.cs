using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    //constructor
	public Item(int id, string title, string description,  Dictionary<string,int> stats)
    {
        this.id = id;
        this.title = title;
        this.description = description; 
         this.icon = Resources.Load<Sprite>("Sprites/Food/" + title); //fix this resource if you can't see the image
        this.stats = stats;
    }

    //class that takes in an Item class
    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Sprites/Food/" + item.title);
        this.stats = item.stats;

    }


}
