using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // The players chosen character, including any stats and items exclusive to the character. Can be traded. 
    public CharacterType characterType;
    // A list containing the contents of the Player's inventory. 
    

    // Constructor for the player. 
    public Player(string name, uint team, Stats startingStats) : base(name, team, startingStats)
    {
        
    }


}
