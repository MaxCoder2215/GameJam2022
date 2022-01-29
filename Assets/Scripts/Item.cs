using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    // Temporary Stat boosts
    public Stats temp_stats;
    // Permanent Stat increases
    public Stats equip_stats;
    // Item name
    public string name;
    // What it is
    public string description;
    // What outside effects it may have.
    public string outside_effect;
    // How many turns its active. 
    public int temp_turn_count;
    // Do we destroy it after it is used.
    public bool destroy_after_use;
    // How often per action or battle the item can be used.
    public int use_cooldown; 


    public Item(Stats tempoaryStats, string itemName, string itemDescription, bool destroyAfterUse)
    {
        temp_stats = tempoaryStats;
        name = itemName;
        description = itemDescription;
        destroy_after_use = destroyAfterUse;
    }

    public Item(Stats equipStats, string itemName, string itemDescription, int turnCount, bool destroyAfterUse, int useCooldown)
    {
        equip_stats = equipStats;
        name = itemName;
        description = itemDescription;
        temp_turn_count
        destroy_after_use = destroyAfterUse;
        use_cooldown = useCooldown;
    }

    public Item(Stats tempoaryStats, string itemName, string itemDescription, string outsideEffect, int turnCount, bool destroyAfterUse, int useCooldown)
    {
        temp_stats = tempoaryStats;
        name = itemName;
        description = itemDescription;
        outside_effect = outsideEffect;
        temp_turn_count = turnCount;
        destroy_after_use = destroyAfterUse;
        use_cooldown = useCooldown; 
    }

    public Item(Stats tempoaryStats, Stats equipStats, string itemName, string itemDescription, string outsideEffect, int turnCount, bool destroyAfterUse, int useCooldown)
    {
        temp_stats = tempoaryStats;
        equip_stats = equipStats;
        name = itemName;
        description = itemDescription;
        outside_effect = outsideEffect;
        temp_turn_count = turnCount;
        destroy_after_use = destroyAfterUse;
        use_cooldown = useCooldown;
    }
}
