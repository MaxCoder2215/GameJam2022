using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity 
{
    // The entity's starting stats.
    protected Stats baseStats;
    // The entity's stats after bonuses.
    protected Stats currentStats;

    // Setter for the entity's base stats.
    public void setBaseStats(Stats b)
    {
        baseStats = b;
    }

    // Setter for the entity's temporary stats.
    public void setCurrentStats(Stats c)
    {
        currentStats = c;
    }
}
