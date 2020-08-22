using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBonus
{
    public int BonusValue { get; set; }

    public StatBonus(int bonusValue)
	{
        if (bonusValue > 0)
        {
            this.BonusValue = bonusValue;
            Debug.Log("Bonus added");
        }
        else
        {
            this.BonusValue = bonusValue;
            Debug.Log("Bonus removed");
        }
    }

}
