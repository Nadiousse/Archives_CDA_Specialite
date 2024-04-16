using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_classes_interfaces_DungeonAdventurer
{
    public class Room
    {
        public Encounter Encounter { get; set; }
        public Room(Encounter encounter)
        {
            Encounter = encounter;
        }

        public void DisplayRoom()
        {
            Console.WriteLine($"Dans cette salle, il y a : {Encounter.Name}.");
        }
    }
}