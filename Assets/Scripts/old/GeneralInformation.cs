/*---- This file does:
 * This file will contain all the global variable for the project. e.g the date, days, time, npc number etc
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralInformation : MonoBehaviour
{
    //variables stored
    public static int daysSpent = 0;


    //how long till the day ends
    public static int Timevar
    {
		get { return 180; }
    }

    //the days spent in the game
    public static int DaysinWorld
    {
        get { return daysSpent; }

        set { daysSpent = value; }
    }

}
