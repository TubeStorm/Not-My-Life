/*------------------------------------------------------------------------------------
//-------------------------------------SHOP UI----------------------------------------
/------------------------------------------------------------------------------------*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    [Header("List of items sold")]
    [SerializeField] private ShopItem[] shopItem;

    [Header("References")]
    [SerializeField] private Transform shopContainer;
    [SerializeField] private GameObject shopItemPrefab;

    private ShopItem si;

    void Update()
    {
    }



    void Start()
    {
        PopulateShop();
    }


    private void PopulateShop()
    {

        for (int i = 0; i < shopItem.Length; i++)
        {

            si = shopItem[i];
            GameObject itemObject = Instantiate(shopItemPrefab, shopContainer); //put prefab in container
            Button buttonCtrl = itemObject.GetComponent<Button>();


       
            buttonCtrl.name = si.itemName;
            //itemObject.GetComponent<Image>().color = si.backgroundColor;



            buttonCtrl.transform.GetChild(0).GetComponent<Image>().sprite = si.sprite;
            buttonCtrl.transform.GetChild(1).GetComponent<Text>().text = si.itemName;
            buttonCtrl.transform.GetChild(2).GetComponent<Text>().text = "$ " + si.price;

        }

    }

}
