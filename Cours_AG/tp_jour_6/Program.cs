using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weaponList =
            {
                "La Hâche Céleste",
                "L'Epée des Enfers",
                "La Lance Verdoyante",
                "La Dague du Supplice",
                "La Claymore de ses Morts",
                "La Boule Magique",
                "La Gourdin Nain",
                "L'Arc de Centaures",
                "Le Filet du Minotaure"
            };

            string[] armorList =
            {
                "La Tunique du Christ",
                "L'Armure de Satan",
                "La Tenue du Barde",
                "Le Filet du Mort-vivant",
                "La Tenue du Sapeur",
                "La Toison d'Or",
                "La Cape d'Invisibilité",
                "Le String du Développeur"
            };

            Random randomWeaponArmor = new Random();
            Random randomDamageProtectionPoints = new Random();

            Weapon weaponFirstCharacter = new Weapon(weaponList[randomWeaponArmor.Next(0,weaponList.Length)], randomDamageProtectionPoints.Next(1,8));
            Weapon weaponSecondCharacter = new Weapon(weaponList[randomWeaponArmor.Next(0, weaponList.Length)], randomDamageProtectionPoints.Next(1, 8));

            Armor armorFirstCharacter = new Armor(armorList[randomWeaponArmor.Next(0, armorList.Length)], randomDamageProtectionPoints.Next(1, 8));
            Armor armorSecondCharacter = new Armor(armorList[randomWeaponArmor.Next(0, armorList.Length)], randomDamageProtectionPoints.Next(1, 8));

            Character thomas = new Character("Thomas", weaponFirstCharacter, armorFirstCharacter);
            Character pierreLouis = new Character("Pierre-Louis", weaponSecondCharacter, armorSecondCharacter);

            int roundsNumber = 0;

            do
            {
                if ((roundsNumber % 2) == 0)
                {
                    pierreLouis.AttackAnotherCharacter(thomas);
                    Console.ReadLine();
                } else
                {
                    thomas.AttackAnotherCharacter(pierreLouis);

                    Console.Write("\nAppuyez sur Entrée pour continuer.");
                    Console.ReadLine();
                    Console.Clear();
                }

                roundsNumber++;

            } while (pierreLouis.GetHealthPoints() != 0 && thomas.GetHealthPoints() != 0);

            Console.ReadLine();
        }
    }
}
