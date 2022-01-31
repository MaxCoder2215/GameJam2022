using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class Entity : ITickable
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

    protected List<Item> activeItems = new List<Item> ();

    protected int currentTick = 0;
    protected bool isAlive = true;

    public UnityEvent OnDie = new UnityEvent();
    public UnityEvent OnTakeTurn = new UnityEvent();


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

    public void GameTick()
    {
        currentTick++;

        if(currentTick > CurrentStats.AttackSpeed && isAlive)
        {
            currentTick = 0;
            TakeTurn();
        }
    }

    public void TakeTurn()
    {
        OnTakeTurn.Invoke();
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
    
    private void CheckHealth()
    {
        if(CurrentStats.Health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        isAlive = false;

    }

}
