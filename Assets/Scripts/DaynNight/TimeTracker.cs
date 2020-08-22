/*---- This file does:
 * Uses slider to control the Day n Night bar, contains the gradiaent information in the Time Trackerclass.
 * Checks to see how many days is spent in the world by checking for if the time has reaches 180.
 * 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTracker : MonoBehaviour
{
    //create variables
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    private float TimeOfDay;
    public int days;


    public int maxTime;
    public int currentTime;

    void Start()
    {
        maxTime = GeneralInformation.Timevar;

        currentTime = maxTime;
        slider.maxValue = maxTime;
        slider.value = currentTime;

        //gradient
        fill.color = gradient.Evaluate(1f);

    }

        private void Update()
    {
       
            //(Replace with a reference to the game time)
            TimeOfDay += 0.02f;
            TimeOfDay %= maxTime; //Modulus to ensure always between 0-180   [5 = less time, 180 = more time]
            int dayChecker = (int)TimeOfDay;
            //Debug.Log(Time.deltaTime);


            //days spent in world based on osscilation of the light.
            if (dayChecker == 180-1)
            {
                days = GeneralInformation.DaysinWorld + 1;
                GeneralInformation.DaysinWorld = days;
                Debug.Log(days);

            }


            slider.value = TimeOfDay;
            fill.color = gradient.Evaluate(slider.normalizedValue);
        
    }


  
}
