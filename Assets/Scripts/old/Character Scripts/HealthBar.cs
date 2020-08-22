using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //create slider variable
    public Slider slider;
    public Gradient gradient;
    public Image fill;


    // create new function that takes the slider max value and puts it into health variable
    public void SetMaxHealth(int health)
	{
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
	}

    // create new function that takes slider value and stores in health variable
    public void SetHealth(int health)
	{
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
	}
  
}
