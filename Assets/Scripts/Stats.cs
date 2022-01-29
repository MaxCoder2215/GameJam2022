using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats 
{

    // Main Stats each Enity will possess.
    public float health;
    public float attack_damage;
    public float attack_speed;
    public float defense;
    public float critical_rate;

    // Constructor
    public Stats (float hP, float aD, float aS, float dF, float cR)
    {
        health = hP;
        attack_damage = aD;
        attack_speed = aS;
        defense = dF;
        critical_rate = cR;
    }

    // Modifies base stats permanently. 
    public void Modify(Stats statModifiers)
    {
        health = statModifiers.health + health;
        attack_damage = statModifiers.attack_damage + attack_damage;
        attack_speed = statModifiers.attack_speed + attack_speed;
        defense = statModifiers.defense + defense;
        critical_rate = statModifiers.critical_rate + critical_rate;
    }
}
