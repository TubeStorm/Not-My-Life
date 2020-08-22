using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats 
{
    public List<StatBonus> BaseAdditives { get; set; }
    public int BaseValue { get; set; }
    public string StatName { get; set; }
    public string StatDescription{ get; set; }
    public int FinalValue { get; set; }

    public BaseStats(int baseValue, string statName, string statDescription)
	{
        //each stat, has an empty list of stat bonuses
        this.BaseAdditives = new List<StatBonus>();
        this.BaseValue = baseValue;
        this.StatName = statName;
        this.StatDescription = statDescription;
	}

    //ADD STAT BONUS FROM LIST
    public void AddStatBonus(StatBonus statBonus)
	{
        this.BaseAdditives.Add(statBonus);
    }

    //REMOVE STAT BONUS FROM LIST
    public void RemoveStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Remove(statBonus);
    }

    //CALCULATE THE FINAL VALUE OF STAT
    public int GetCalculatedStatValue()
	{
        // x is a stat bonus with properties that we want to keep adding into the final value (used foreach instead of foor loop)
        this.BaseAdditives.ForEach(x => this.FinalValue += x.BonusValue);
        FinalValue += BaseValue;

        /*

        for (int i = 0; i < BaseAdditives.Count; i++)
		{
            this.BaseAdditives.ForEach(x => this.FinalValue += x.BonusValue);
            FinalValue += BaseValue; 
		}
        */
        return FinalValue; 
	}
}
