using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWellness : MonoBehaviour
{
    //variables
    public int maxHappiness = 100;
    public int currentHappiness;

    public int maxEnergy = 100;
    public int currentEnergy;

    public int maxSmarts = 100;
    public int currentSmarts;

    public int maxLooks = 100;
    public int currentLooks;


    public HappinessBar happinessBar;
    public EnergyBar energyBar;
    public SmartsBar smartsBar;
    public LooksBar looksBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHappiness = maxHappiness;
        happinessBar.SetMaxHappiness(maxHappiness);

        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);

        currentSmarts = maxSmarts;
        smartsBar.SetMaxSmarts(maxSmarts);

        currentLooks = maxLooks;
        looksBar.SetMaxLooks(maxLooks);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

    }

    void TakeDamage(int damage)
    {
        currentHappiness -= damage;
        happinessBar.SetHappiness(currentHappiness);

        currentEnergy -= damage;
        energyBar.SetEnergy(currentEnergy);

        currentSmarts -= damage;
        smartsBar.SetSmarts(currentSmarts);

        currentLooks -= damage;
        looksBar.SetLooks(currentLooks);
    }
}
