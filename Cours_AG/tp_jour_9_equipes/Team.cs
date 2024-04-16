using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tp_jour_9_equipes
{
    internal class Team
    {
        public string Name { get; set; }
        public List<Player> PlayersList { get; }
        public List<Player> CurrentPlayersList { get; set; }

        public Team(string name, string[] playerList)
        {
            Name = name;
            PlayersList = new List<Player>();

            PlayersList = InitializePlayersList(playerList);
            CurrentPlayersList = PlayersList;
        }

        public List<Player> InitializePlayersList(string[] prenoms) 
        {
            List<Player> newPlayersList = new List<Player>();

            for (int i = 0; i < 6; i++)
            {
                newPlayersList.Add(new Player(prenoms[i]));
            }

            return newPlayersList;
        }

        public Player ReturnRandomPlayer()
        {
            Random rand = new Random();

            Player returnPlayer = CurrentPlayersList[rand.Next(CurrentPlayersList.Count)];

            return returnPlayer;
        }
    }
}
