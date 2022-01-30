using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // The players chosen character, including any stats and items exclusive to the character. Can be traded. 
    public CharacterType characterType;
    public Item[] Iventory; 

    public Player (Stats startingStats)
    {
        baseStats = startingStats; 
    }


}
