using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_GungeonExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Encounter> encounterList = new List<Encounter>();
            encounterList.Add(new Monster("Slime", 20, 2, 4));
            encounterList.Add(new Trap("Un trou dans le sol", 10));
            encounterList.Add(new Item("Petite Potion de Vie", 30));
            encounterList.Add(new Monster("Slime Boss", 50, 10, 8));

            Dungeon dungeon = new Dungeon(4, encounterList);

            Adventurer adventurer = new Adventurer();
            Game.CreateAnAdventurer(adventurer);

            Game.SeparateLines();
            dungeon.DisplayAllRooms();

            Console.ReadLine();
        }
    }
}
