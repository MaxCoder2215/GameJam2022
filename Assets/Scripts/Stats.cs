using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats 
{

    // Main Stats each Enity will possess.
    public float Health { get; set; }
    public float AttackDamage { get; set; }
    public float AttackSpeed { get; set; }
    public float Defense { get; set; }
    public float CriticalRate { get; set; }
    public float Gold { get; set; }
    public float Morale { get; set; }

    // Constructor
    public Stats (float hP, float aD, float aS, float dF, float cR, float gD, float mR)
    {
        Health = hP;
        AttackDamage = aD;
        AttackSpeed = aS;
        Defense = dF;
        CriticalRate = cR;
        Gold = gD;
        Morale = mR;
    }

    // Modifies base stats permanently. 
    public void Modify(Stats statModifiers)
    {
        Health = statModifiers.Health + Health;
        AttackDamage = statModifiers.AttackDamage + AttackDamage;
        AttackSpeed = statModifiers.AttackSpeed + AttackSpeed;
        Defense = statModifiers.Defense + Defense;
        CriticalRate = statModifiers.CriticalRate + CriticalRate;
    }
}
