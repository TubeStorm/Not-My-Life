using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LooksBar : MonoBehaviour
{
    //create slider variable
    public Slider slider;


    // create new function that takes the slider max value and puts it into health variable
    public void SetMaxLooks(int looks)
    {
        slider.maxValue = looks;
        slider.value = looks;
    }

    // create new function that takes slider value and stores in health variable
    public void SetLooks(int looks)
    {
        slider.value = looks;
    }

}
