using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessBar : MonoBehaviour
{
    //create slider variable
    public Slider slider;
    public float happiness;
    public float currentHappiness;


    // create new function that takes the happiness variable and puts it into slider max value
    public void SetMaxHappiness(int happiness)
    {
        slider.maxValue = happiness;
        slider.value = happiness;
    }

    // create new function that takes happiness variable and stores in slider  value
    public void SetHappiness(int happiness)
    {

        slider.value = happiness;
    }

}

