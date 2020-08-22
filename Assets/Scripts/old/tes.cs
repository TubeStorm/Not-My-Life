using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinesssBar : MonoBehaviour
{
    //create slider variable
    public Slider slider;
    public float happiness;
    public float currentHappiness;

    //lists
    public List<HappinessSort> sorts = new List<HappinessSort>();

    void Update()
    {
        IsRemoving();
        removeHappiness();
        //removeHappiness();
    }

    public void IsRemoving()
    {
        //walking
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            sorts[1].isRemoving = true;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                sorts[2].isRemoving = true;
            }
            else
            {
                sorts[2].isRemoving = false;
            }
        }
        else
        {
            sorts[1].isRemoving = false;
            sorts[2].isRemoving = false;
        }




        /*jumping (remove game does not have jumping)
        if (Input.GetButton("Jump"))
        {
            sorts[3].isRemoving = true;
        }
        else
        {
            sorts[3].isRemoving = false;
        }
        */

    }


    public void removeHappiness()
    {
        currentHappiness = 0;

        foreach (HappinessSort h in sorts)
        {
            if (h.isRemoving)
            {
                currentHappiness += h.happiness / 100;
            }
        }

        happiness -= currentHappiness * Time.deltaTime;

        if (happiness <= 0)
        {
            //die
        }

    }

    /*
        public void receivingHappiness()
        {
            //if eating add health
            if (Input.GetKeyDown(keycode.Q))
            {
                happiness += 10;

                if (happiness >= 100)
                {
                    happiness = 100;
                }
            }

        }
        */

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

[System.Serializable]
public class HappinessSort
{

    public string name;
    public float happiness;
    public bool isRemoving = false;


}

