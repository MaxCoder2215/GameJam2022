using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    // Temporary Stat boosts.
    public Stats tempStats;
    // Permanent Stat increases.
    public Stats equipStats;
    // Item name.
    public string name;
    // What it is.
    public string description;
    // What outside effects it may have.
    public string outsideEffect;
    // How many turns its active. 
    public int tempTurnCount;
    // Do we destroy it after it is used.
    public bool destroyAfterUse;
    // How often per action or battle the item can be used.
    public int useCooldown; 

    // Constructor for an item that is either temporary or equiptable. 
    public Item(Stats stats, string itemName, string itemDescription, string effect, int turnCount, bool destroy, int cooldown)
    {
        
        name = itemName;
        description = itemDescription;
        outsideEffect = effect;
        tempTurnCount = turnCount;
        destroyAfterUse = destroy;
        useCooldown = cooldown;

        if (destroyAfterUse)
        {
            tempStats = stats;
        } else
        {
            equipStats = stats;
        }
       
    }

    // Constructor for an item with both temporary stat increases and equipment stats. 
    public Item(Stats temporaryStats, Stats eStats, string itemName, string itemDescription, string effect, int turnCount, bool destroy, int cooldown)
    {
        tempStats = temporaryStats;
        equipStats = eStats;
        name = itemName;
        description = itemDescription;
        outsideEffect = effect;
        tempTurnCount = turnCount;
        destroyAfterUse = destroy;
        useCooldown = cooldown;
    }
}
