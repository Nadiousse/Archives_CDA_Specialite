using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_GungeonExplorer
{
    public class Room
    {
        public Encounter OneEncounter { get; set; }
        public Room(Encounter encounter) 
        {
            OneEncounter = encounter;
        }

        public void DisplayRoom()
        {
            Console.WriteLine($"Dans cette salle, il y a : {OneEncounter.Name}.");
        }
    }
}