using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam2022Server
{
    public class Item
    {
        // Item name.
        public string Name { get; set; }
        // What it is.
        public string Description { get; set; }
        // What outside effects it may have.
        public string OutsideEffect { get; set; }
        // How many turns its active. 
        public int TempTurnCount { get; set; }
        // Do we destroy it after it is used.
        public bool DestroyAfterUse { get; set; }
        // How often per action or battle the item can be used.
        public int UseCooldown { get; set; }

        // Temporary Stat boosts.
        public Stats TempStats { get; set; }
        // Permanent Stat increases.
        public Stats EquipStats { get; set; }

        public bool equippded = false;

        // Constructor for an item that is either temporary or equiptable. 
        public Item(Stats stats, string itemName, string itemDescription, string effect, int turnCount, bool destroy, int cooldown)
        {

            Name = itemName;
            Description = itemDescription;
            OutsideEffect = effect;
            TempTurnCount = turnCount;
            DestroyAfterUse = destroy;
            UseCooldown = cooldown;

            if (DestroyAfterUse)
            {
                TempStats = stats;
            }
            else
            {
                EquipStats = stats;
            }

        }

        // Constructor for an item with both temporary stat increases and equipment stats. 
        public Item(Stats temporaryStats, Stats eStats, string itemName, string itemDescription, string effect, int turnCount, bool destroy, int cooldown)
        {
            TempStats = temporaryStats;
            EquipStats = eStats;
            Name = itemName;
            Description = itemDescription;
            OutsideEffect = effect;
            TempTurnCount = turnCount;
            DestroyAfterUse = destroy;
            UseCooldown = cooldown;
        }
    }
}