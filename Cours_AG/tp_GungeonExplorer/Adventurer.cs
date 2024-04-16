using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_GungeonExplorer
{
    public class Adventurer
    {
        public string Name { get; set; }

        public List<Characteristics> Characteristics { get; set; }

        public Adventurer(string initName) 
        {
            Name = initName;

            Characteristics = new List<Characteristics>();
            Characteristics.Add(new Characteristics(EffectTypes.HP, 100));
            Characteristics.Add(new Characteristics(EffectTypes.Attack, 10));
            Characteristics.Add(new Characteristics(EffectTypes.Speed, 5));
        }

        public void DisplayAdventurerInformation()
        {
            Console.WriteLine($"\"{Name}\", HP: {Characteristics[0]}, Attack: {Characteristics[1]}, Speed: {Characteristics[2]}");
        }

        public void DisplayInBatlle()
        {
            Console.WriteLine($"\"{Name}\", HP: {Characteristics[0]}");
        }

        public void AttackMonster(Monster monster)
        {
            monster.Characteristics[0].EffectValue -= Characteristics[1].EffectValue;
            Console.WriteLine($"Vous faites {Characteristics[1]} de points de dégats au {monster.Name}.");
        }
    }
}