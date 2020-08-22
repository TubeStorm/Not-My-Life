using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DKStore : ActionItem
{
    public GUISkin mySkin;
    public Rect windowRect = new Rect(1350, 175, 1146, 1486);

    bool showPopUpWindow;

    void Start()
    {
        showPopUpWindow = false;

    }


    void Update()
    {
        if (Input.GetKey("q"))
        {
            showPopUpWindow = !showPopUpWindow;
        }
    }

    void OnGUI()
    {
        GUI.skin = mySkin;
        if (showPopUpWindow) windowRect = GUI.Window(0, windowRect, DoMyWindow, "Destiny Knight Store");
    }

    void DoMyWindow(int windowID)
    {
        GUI.Button(new Rect(40, 80, 150, 130), "Buy Membership");
        GUI.Button(new Rect(40, 200, 150, 30), "Armour");
        GUI.Button(new Rect(40, 230, 150, 30), "Potions");
        GUI.Button(new Rect(40, 260, 150, 30), "Weapons");
        GUI.Button(new Rect(40, 290, 150, 30), "Enchantments");
        GUI.Button(new Rect(40, 320, 150, 30), "Gold");
        GUI.Button(new Rect(200, 200, 500, 30), "Store Inventory");
        GUI.Button(new Rect(200, 80, 500, 130), "Triple XP View Details");
        GUI.Button(new Rect(200, 220, 150, 130), "Armours");
        GUI.Button(new Rect(200, 320, 150, 30), "View All Item");
        GUI.Button(new Rect(375, 220, 150, 130), "Potions");
        GUI.Button(new Rect(375, 320, 150, 30), "View All Items");
        GUI.Button(new Rect(550, 220, 150, 130), "Currency");
        GUI.Button(new Rect(550, 320, 150, 30), "View All Items");
        GUI.Button(new Rect(200, 360, 500, 30), "Featured Deals");
        GUI.DragWindow(new Rect(0, 0, 10000, 10000));
    }
}
