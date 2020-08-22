/*---- This file does:
 * Takes the day count from the TimeTracker.cs file and displays it on the days text in unity's UI
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCounter : MonoBehaviour
{
    //public Light DirectionalLight;
    public Text dayCount;

    // Update is called once per frame
    void Update()
    {
        //dayCount.text = DirectionalLight.transform.localRotation.ToString("0"); //get the value from the rotation on the direction light

        dayCount.text = GeneralInformation.DaysinWorld.ToString("0"); //the 0 makes it an int
        //Debug.Log(GeneralInformation.DaysinWorld);

    }
}
