using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_GungeonExplorer
{
    public class Trap : Encounter
    {
        public int HealthDecreaseNumber { get; set; }

        public Trap(string initName, int healthDecreaseNumber) : base(initName)
        {
            HealthDecreaseNumber = healthDecreaseNumber;
        }
        public void UseItem(Adventurer adventurer)
        {
            adventurer.Health -= HealthDecreaseNumber;
        }
    }
}