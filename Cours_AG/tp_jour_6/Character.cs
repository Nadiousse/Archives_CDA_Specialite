using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_6
{
    internal class Character
    {
        /*
         * name
         * healthpoints
         * weapon
         * armor
         * + attack another character
         * + display
         */

        string name;
        int healthPoints = 100;
        Weapon weapon;
        Armor armor;

        public Character()
        {
            name = "";
        }

        public Character(string initName, Weapon initWeapon, Armor initArmor)
        {
            name = initName;
            weapon = initWeapon;
            armor = initArmor;
        }

        public void SetName(string setName)
        {
            name = setName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetHealthPoints(int setHealthPoints)
        {
            healthPoints = setHealthPoints;
        }

        public int GetHealthPoints()
        {
            return healthPoints;
        }

        public void DamageHealthPoints(int damagePoints)
        {
            healthPoints -= damagePoints;
        }

        public void SetWeapon(Weapon setWeapon)
        {
            weapon = setWeapon;
        }

        public Weapon GetWeapon()
        {
            return weapon;
        }

        public void SetArmor(Armor setArmor)
        {
            armor = setArmor;
        }

        public Armor GetArmor()
        {
            return armor;
        }

        public void AttackAnotherCharacter(Character target)
        {
            int damage;

            if (target.GetArmor().GetProtectionValue() >= this.GetWeapon().GetAttackValue())
            {
                damage = 1;
                target.DamageHealthPoints(damage);
                Console.WriteLine($"L'armure de {target.GetName()} est trop résistante. La cible a subi un point de dégat avec {this.weapon.GetName()}.");
            } else
            {
                damage = this.GetWeapon().GetAttackValue() - target.GetArmor().GetProtectionValue();
                target.DamageHealthPoints(damage);
                Console.WriteLine($"{target.GetName()} a subi {damage} de dégat avec {this.weapon.GetName()}.");
            }

            target.DisplayStatus();

            if (target.GetHealthPoints() <= 0)
            {
                DisplayWinnerAndLooser(target);
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine("-----");
            Console.WriteLine("Nom du joueur : " + this.GetName());
            Console.WriteLine("Points de vie : " + this.GetHealthPoints());
            Console.WriteLine("Armure équipée : " + this.GetArmor().GetName());
            Console.WriteLine("-----");
        }

        public void DisplayWinnerAndLooser(Character looser)
        {
            Console.WriteLine($"{this.GetName()} a gagné ce duel face à {looser.GetName()}.");
        }
    }
}
