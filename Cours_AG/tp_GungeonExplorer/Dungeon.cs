using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_GungeonExplorer
{
    public class Dungeon
    {
        public int NumberOfRooms { get; set; }
        public int CurrentRoom { get; set; }
        public List<Room> ListOfRooms { get; set; }

        public Dungeon(int initNumberOfRooms, List<Encounter> encountersList) 
        {
            NumberOfRooms = initNumberOfRooms;
            CurrentRoom = -1;
            ListOfRooms = new List<Room>();

            InitializeAllRooms(NumberOfRooms, ListOfRooms, encountersList);

            Console.WriteLine($"Le dongeon a un total de {NumberOfRooms} salles.\n");
        }

        public void DisplayDungeonMap()
        {
            Game.SeparateLines();
            if (CurrentRoom == -1)
            {
                Console.WriteLine("Vous n'êtes pas encore dans les dongeon.");
            } else
            {
                Console.WriteLine($"Vous êtes actuellement à la salle {CurrentRoom}");
            }
            Game.SeparateLines();
        }

        public void InitializeAllRooms(int numberOfRooms, List<Room> listOfRooms, List<Encounter> encountersList)
        {
            for (int i = 0; i < numberOfRooms;i++)
            {
                listOfRooms.Add(new Room(encountersList[i]));
            }
        }

        public void DisplayOneRoom(int roomNumber)
        {
            Console.WriteLine($"Salle numéro {roomNumber + 1} :");
            ListOfRooms[roomNumber].DisplayRoom();
        }

        public void DisplayAllRooms()
        {
            for (int i = 0; i < NumberOfRooms; i++)
            {
                DisplayOneRoom(i);
            }
        }
    }
}