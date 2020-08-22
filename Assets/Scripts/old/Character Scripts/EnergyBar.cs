using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    //create slider variable
    public Slider slider;


    // create new function that takes the slider max value and puts it into health variable
    public void SetMaxEnergy(int energy)
    {
        slider.maxValue = energy;
        slider.value = energy;
    }

    // create new function that takes slider value and stores in health variable
    public void SetEnergy(int energy)
    {
        slider.value = energy;
    }

}
