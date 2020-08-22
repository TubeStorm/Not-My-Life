using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> uIItems = new List<UIItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public FoodDatabase myVendingMachine;

    private void Awake()
	{
        
        //myVendingMachine.GLOBALnumberOfSlots
        for (int i = 0; i < 20; i++)
		{
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            uIItems.Add(instance.GetComponentInChildren<UIItem>());
           

        }
	}

    private void Start()
    {
       
    }


    public void UpdateSlot(int slot, Item item)
	{
        uIItems[slot].UpdateItem(item);
	}

    public void AddNewItem(Item item)
    {
        //check for the first slot with no items and add an item there
        UpdateSlot(uIItems.FindIndex(i => i.item == null), item);
    }

    public void RemoveItem(Item item)
    {
        //check for the first slot with no items and add an item there
        UpdateSlot(uIItems.FindIndex(i => i.item == item), null);
    }
}
