using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public static CharacterStats instance;
    static protected int happinessValue = 100;
    static protected float energyValue = 100;
    static protected int smartValue = 100;
    static protected int looksValue = 100;
    static protected int money = 500;
    static protected string characterType = "lazy";
                                 
    [Header("Character Variables")]
    public List<BaseStats> HappinessStats = new List<BaseStats>();

    private GameObject floor;

    [Header("Character UI")]
    [SerializeField] private Slider happiness;
    [SerializeField] private Slider energy;
    [SerializeField] private Slider smart;
    [SerializeField] private Slider looks;
    [SerializeField] private GameObject moneyUI;
    public int count = 0;

    [HideInInspector]
    private float damage;
    private Vector3 last_pos;




    void Start()
	{
        instance = this;

        /*HAPPINESS
        HappinessStats.Add(new BaseStats(100, "Happiness: ", "Your Happiness level"));
        HappinessStats[0].AddStatBonus(new StatBonus(-50));
        Debug.Log("Happiness" + HappinessStats[0].GetCalculatedStatValue());
        */


        //----------------LOAD DATA-----------------

        last_pos = transform.position;
        damage = 25;

        //---------------------------------------------

    }


    void Update()
    {
        isWalking();
        maxCheck();
        Debug.Log("the enrgy is now : " + energyValue);


    }


    void maxCheck()
	{


        if(happinessValue >= 100)
		{
            happiness.value = 100;
            happinessValue = 100;
        }
		else
		{
            happiness.value = happinessValue;
        }
        if (energyValue >= 100)
        {
            energy.value = 100;
            energyValue = 100;
        }
		else
		{
            energy.value = energyValue;
        }
        if (smartValue >= 100)
        {
            smart.value = 100;
            smartValue = 100;
        }
        else
        {
            smart.value = smartValue;
        }
        if (looksValue >= 100)
        {
            looks.value = 100;
            looksValue = 100;
        }
        else
        {
            looks.value = looksValue;
        }
        if (money >= 1000000)
        {
            moneyUI.GetComponent<Text>().text = "1000000";
            money = 1000000;
        }
        else
        {
            moneyUI.GetComponent<Text>().text = "" + money;
        }

	}



    void isWalking()
	{
        Vector3 velocity = WorldInteraction.instance.velocity1;
        if (velocity[0] != 0 || velocity[2] != 0)
        {

            //Debug.Log("moving" + transform.position);
            Debug.Log("energy" + energy.value);
            energyValue -= damage * (Vector3.Distance(transform.position , last_pos)) * Time.fixedDeltaTime;
            happiness.value += (damage - 1) * (Vector3.Distance(transform.position, last_pos)) * Time.fixedDeltaTime;
            last_pos = transform.position;
        }
        else
        {
            Debug.Log("not moving");

        }
    }


    //checks to see if a user has eaten something to then increase happiness and energy
    public void IsEating()
	{

	}

    //checks to see if player is socialing with with a friend or enemy
    public void IsSocialising()
	{

	}

    //have money change the amount in UI
    public void PlayerAccount()
	{

    }

  


/*------------------------------------------------------------------------------------
//---------------------------------SAVING SCENE DATA-----------------------------------
/------------------------------------------------------------------------------------*/

    void OnDestroy()
	{
    }

    /*---------------------------STATS GETTERS AND SETTERS---------------------------*/

    public static int GetMoney()
	{
        return money;
	}

    public static void SetMoney(int price)
    {
        money += price;
    }

    public static int GetHappiness()
    {
        return happinessValue;
    }

    public static void SetHappiness(int value)
    {
        happinessValue += value;
    }

    public static float GetEnergy()
    {
        return energyValue;
    }

    public static void SetEnergy(float value)
    {
        energyValue += value;
    }

    public static string GetCharType()
    {
        return characterType;
    }

    public static void SetCharType(string type)
    {
        characterType = type;
    }
}
