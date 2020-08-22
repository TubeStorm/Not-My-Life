/*---- This file does:
 * is a class holding the 3 basic variables that will be used for each NPC and main character
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsVariables : MonoBehaviour
{
    public string Name;
    public int Max;
    public int Value;
    public int Current;

    public StatsVariables(string names, int maxs, int values, int currents)
    {
        Name = names;
        Max = maxs;
        Value = values;
        Current = currents;
    }
}



//ALLOWS US TO CHECK STATES OF OUR CHARACTERS
public class customSort : MonoBehaviour
{
    public string Name;
    public float value;
    public bool isRemoving;

    public customSort(string names, float values, bool isRemovings)
    {
        name = names;
        value = values;
        isRemoving = isRemovings;
    }
}