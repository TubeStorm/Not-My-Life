/*---- This file does:
 * Holds the status for all characters in the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsBar : MonoBehaviour
{

    public StatsVariables charEnergy;
    public EnergyCal Energy;

    // Start is called before the first frame update
    void Start()
    {
        charEnergy.Max = 100;
        charEnergy.Current = charEnergy.Max;


    }

    // Update is called once per frame
    void Update()
    {

        //taking damage from walking and prints out the value
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Debug.Log("heloo");
        }

        Energy.IsWalking();
        charEnergy.Current = Energy.removeEnergy(charEnergy.Max, charEnergy.Current);
        Debug.Log("current " + charEnergy.Current);



    }

}
