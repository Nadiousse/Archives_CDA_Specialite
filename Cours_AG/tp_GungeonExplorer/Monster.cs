using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_GungeonExplorer
{
    public class Monster : Encounter
    {
        public Monster(string name, int health, int attack, int speed) : base(name, Encounters.monster, health, attack, speed)
        {
        }

        public override void MeetTheEncounter()
        {
            Console.WriteLine($"Il y a un {Name} dans cette salle. Faut combattre le monstre pour pouvoir avancer.");
        }

        public void AttackAdventurer(Adventurer adventurer)
        {
            adventurer.Characteristics[0].EffectValue -= Characteristics[1].EffectValue;
            Console.WriteLine($"Le monstre vous fait {Characteristics[1].EffectValue} de points de dégats.");
        }

        public void DisplayInBattle()
        {
            Console.WriteLine($"\"{Name}\", HP: {Characteristics[0].EffectValue}");
        }
    }
}