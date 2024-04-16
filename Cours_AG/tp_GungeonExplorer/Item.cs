using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_GungeonExplorer
{
    public class Item : Encounter
    {
        public int HealthRegainNumber { get; set; } 

        public Item(string initName, int healthRegainNumber) : base(initName)
        {
            HealthRegainNumber = healthRegainNumber;
        }

        public void UseItem(Adventurer adventurer)
        {
            adventurer.Health += HealthRegainNumber;
        }
    }
}