using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartsBar : MonoBehaviour
{
    //create slider variable
    public Slider slider;


    // create new function that takes the slider max value and puts it into health variable
    public void SetMaxSmarts(int smarts)
    {
        slider.maxValue = smarts;
        slider.value = smarts;
    }
     
    // create new function that takes slider value and stores in health variable
    public void SetSmarts(int smarts)
    {
        slider.value = smarts;
    }

}
