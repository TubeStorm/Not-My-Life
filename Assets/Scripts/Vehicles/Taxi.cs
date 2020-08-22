using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Taxi : MonoBehaviour
{
    public static Taxi instace;

    private GameObject vehicle;
    public float DistanceT;
    public bool isClicked;
    [SerializeField] public GameObject taxiUIVisibility;

    void Start()
    {
        instace = this;

        //---------LOAD DATA FROM PLAYER PREFS---------

        isClicked = (PlayerPrefs.GetInt("IsClicked", 0) != 0);

        //---------------------------------------------

    }

    void Update()
    { 
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            GetTaxiInteraction();

        }
    }


    //get the exact point we are clicking on and open GUI
    void GetTaxiInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;

        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {

            vehicle = interactionInfo.collider.gameObject;
            DistanceT = Vector3.Distance( Vending.instace.player.transform.position, vehicle.transform.position);

            if (vehicle.tag == "Taxi" )
            {
                Debug.Log("Interacting with Taxi ");
                taxiUIVisibility.SetActive(true);
                

            }
        }

    }

    public void closeUI()
    {
        taxiUIVisibility.SetActive(false);
    }

    public void earnMoney()
    {
        isClicked = true;
    }

    public void useTaxi()
    {
        int sumDeduction = 10;
        int total = CharacterStats.GetMoney();

        sumDeduction = total - sumDeduction;
        CharacterStats.SetMoney(sumDeduction);
    }







/*------------------------------------------------------------------------------------
//---------------------------------SAVING SCENE DATA-----------------------------------
/------------------------------------------------------------------------------------*/

    void OnDestroy()
    {
        PlayerPrefs.SetInt("IsClicked", isClicked ? 1 : 0);
    }


}
