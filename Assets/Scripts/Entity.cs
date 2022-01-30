using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity 
{
    // The entity's starting stats.
    protected Stats BaseStats { get; set; }
    // The entity's stats after bonuses.
    protected Stats CurrentStats { get; set; }

    public List<Item> Inventory {get; set;}

    public Entity(Stats startingStats) : this(startingStats, null)
    {

    }
    public Entity(Stats startingStats, List<Item> inventory)
    {
        BaseStats = startingStats;
        CurrentStats = startingStats;
        if (inventory != null)
        {
            this.Inventory = inventory;
        }
        else
        {
            this.Inventory = new List<Item>();
        }
    }
}
