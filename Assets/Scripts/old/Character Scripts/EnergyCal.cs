/*---- This file does:
 * this calcualates the energy drop when the character walks
 * when the characters havent eaten in a long time
 * does certain tasks (mini game)
 *
 * MILESTONES
 * so far it reduces when the character walks
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCal : MonoBehaviour
{
    //VARIABLES
    public List<customSort> energySort = new List<customSort>();


    public void IsWalking()
    {

        energySort.Add(new customSort("Default", 1, true));
        energySort.Add(new customSort("Walking", 2, false));

        //check if character is standing or walking
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            energySort[0].isRemoving = true;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                energySort[1].isRemoving = true;
            }
            else
            {
                energySort[1].isRemoving = false;
            }
        }
        if (Input.GetAxis("Horizontal") == null || Input.GetAxis("Vertical") == null)
        {
            Debug.Log("heloo");
        }
    }

    //CALCULATES THE REMOVED ENERGY
    public int removeEnergy(int maxEnergy, int currentEnergy)
    {

        foreach (customSort e in energySort)
        {
            if (e.isRemoving)
            {
                currentEnergy += (int)(e.value / 100);
            }
        }

        maxEnergy -= (int)(currentEnergy * Time.deltaTime);

        if (maxEnergy <= 0)
        {
            //die
            Debug.Log("YOU DIED");
        }
        return maxEnergy;

    }


}