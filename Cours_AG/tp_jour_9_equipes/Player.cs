using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_9_equipes
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> CardsList { get; set; }

        public Player(string name)
        {
            Name = name;
            CardsList = new List<Card>();
        }
    }
}
