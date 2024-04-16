using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tp_GungeonExplorer
{
    public static class Game
    {
        public static void CreateAnAdventurer(Adventurer adventurer)
        {
            Console.Write("Veuillez entrer le nom de votre aventurier : ");
            string nameInput = Console.ReadLine();
            adventurer.Name = nameInput;

            Console.Write("\n\nVoulez vous un personnage rapide (1) ou fort (2) : ");
            string adventurerChoiceInput = Console.ReadLine();
            int adventurerChoice = int.Parse(adventurerChoiceInput);

            switch (adventurerChoice){
                case 1:
                    adventurer.Speed += 10;
                    break;
                case 2:
                    adventurer.Attack += 10;
                    break;
            }

            Console.Write("\n\nVoici le résumé de votre personnage : ");
            adventurer.DisplayAdventurerInformation();
        }

        public static void SeparateLines()
        {
            Console.WriteLine("--------------------------------------------------------------");
        }

        public static void Battle(Adventurer adventurer, Monster monster)
        {
            bool battleCondition = adventurer.Health == 0 || monster.Health == 0;

            while (!battleCondition)
            {
                if (adventurer.Speed >= monster.Speed)
                {
                    adventurer.AttackMonster(monster);
                    if (battleCondition)
                    {
                        break;
                    }
                    monster.AttackAdventurer(adventurer);
                }
                else
                {
                    monster.AttackAdventurer(adventurer);
                    if (battleCondition)
                    {
                        break;
                    }
                    adventurer.AttackMonster(monster);
                }
                
                Console.WriteLine("\n\n");
                adventurer.DisplayInBatlle();
                monster.DisplayInBattle();
            }
        }

        public static void EnterRoom(Dungeon dungeon, Adventurer adventurer)
        {
            dungeon.CurrentRoom++;
            dungeon.DisplayOneRoom(dungeon.CurrentRoom);



            if (dungeon.ListOfRooms[dungeon.CurrentRoom].OneEncounter.Type == Encounters.monster)
            {
                Monster monster = dungeon.ListOfRooms[dungeon.CurrentRoom].OneEncounter;
                Battle(adventurer, dungeon.ListOfRooms[dungeon.CurrentRoom].OneEncounter);
            }

            if (adventurer.Health <= 0)
            {
                Console.WriteLine("GAME OVER");
            }
            else
            {
                if (dungeon.CurrentRoom == dungeon.NumberOfRooms - 1)
                {
                    Console.WriteLine("Vous avez conquit le dongeon.");
                }
                else
                {
                    EnterRoom(dungeon, adventurer);
                }
            }
        }
    }
}