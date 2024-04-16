using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_classes_interfaces_DungeonAdventurer
{
    public abstract class Encounter : IBattle
    {
        public string Name { get; set; }

        public Encounters Type { get; set; }
        public List<Characteristics> Characteristics { get; set; }

        public Encounter(string initName, Encounters encounterType, Characteristics characteristicType, int initEffectValue)
        {
            Name = initName;
            Type = encounterType;
            List<Characteristic> Characteristics = new List<Characteristic>();
            Characteristics.Add(new Characteristic(characteristicType, initEffectValue));
        }

        public Encounter(string initName, Encounters encounterType, int initHp, int initAttack, int initSpeed)
        {
            Name = initName;
            Type = encounterType;
            List<Characteristics> Characteristics = new List<Characteristics>();

            Characteristics.Add(new Characteristics(EffectTypes.HP, initHp));
            Characteristics.Add(new Characteristics(EffectTypes.Attack, initAttack));
            Characteristics.Add(new Characteristics(EffectTypes.Speed, initSpeed));
        }

        public virtual void MeetTheEncounter()
        {
            Console.WriteLine("\nIl y a quelque chose dans la salle.");
        }
    }
}