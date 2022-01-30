using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats 
{

    // Main Stats each Enity will possess.
    public float health;
    public float attackDamage;
    public float attackSpeed;
    public float defense;
    public float criticalRate;
    public float gold;
    public float morale;

    // Constructor
    public Stats (float hP, float aD, float aS, float dF, float cR, float gD, float mR)
    {
        health = hP;
        attackDamage = aD;
        attackSpeed = aS;
        defense = dF;
        criticalRate = cR;
        gold = gD;
        morale = mR;
    }

    // Modifies base stats permanently. 
    public void Modify(Stats statModifiers)
    {
        health = statModifiers.health + health;
        attackDamage = statModifiers.attackDamage + attackDamage;
        attackSpeed = statModifiers.attackSpeed + attackSpeed;
        defense = statModifiers.defense + defense;
        criticalRate = statModifiers.criticalRate + criticalRate;
    }
}
