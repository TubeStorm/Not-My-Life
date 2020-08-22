using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class Vending : WorldInteraction
{
    public static Vending instace;

    //VARIABLES
    public Shop foodShop;
    public GameObject player;
    private GameObject machine;
    public float Distance;

    [SerializeField] private GameObject vendingOpenScreen;
    [SerializeField] public GameObject vendingContainerVisibility;


    void Start()
    {
        //find the player and enter the player into our object...
        //so we don't have to manually place them in the inspector

        instace = this;

    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
           GetVendingInteraction();

        }
    }


    //get the exact point we are clicking on and open GUI
    void GetVendingInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;


        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {

            machine = interactionInfo.collider.gameObject;

            if (machine.tag == "Vending Machine")
            {

                Debug.Log("HEY I WAS CALLED");
                Debug.Log("OPEN VENDING MACHINE UI");


                vendingOpenScreen.SetActive(true); //turn shop visibility on
               

            }
        }

    }


    public void closeVendingUi()
    {
        vendingOpenScreen.SetActive(false);
    }

    public void openFoodOptions()
    {
        vendingOpenScreen.SetActive(false);
        vendingContainerVisibility.SetActive(true);
    }

    public void openDrinkOptions()
    {
        vendingOpenScreen.SetActive(false);
        vendingContainerVisibility.SetActive(true);
    }


    public void goBackToVendingUi()
    {
        //open the previous Ui
        vendingOpenScreen.SetActive(true);
        vendingContainerVisibility.SetActive(false);
    }







}
