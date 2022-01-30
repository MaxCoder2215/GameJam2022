using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity 
{
    public string Name { get; set; }

    /// <summary>
    /// Current Team for enemy to fight with
    /// </summary>
    public uint Team {get; set;}

    // The entity's starting stats.
    public Stats BaseStats { get; set; }
    // The entity's stats after bonuses.
    public Stats CurrentStats { get; set; }

    public Stats effectedStats;

    public List<Item> Inventory {get; set;}

    private List<Item> activeItems = new List<Item> ();


    public Entity(string name, uint team,Stats startingStats) : this(name, team,startingStats, null)
    {

    }

    public Entity(string name, uint team,Stats startingStats, List<Item> inventory)
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

        this.Team = team;
        this.Name = name;
    }

    public void TakeTurn(List<Entity> inBattle )
    {

    }

    public void EquipItem(Item item)
    {
        BaseStats += item.EquipStats;
        item.AdvanceEquiped(this);
    }

    public void ActivateItem(Item item)
    {
        foreach (Item i in this.activeItems)
        {
            if(i == item)
            {
                return;
            }
        }

        activeItems.Add(item);
        item.AdvanceActivate(this);
    }

}
