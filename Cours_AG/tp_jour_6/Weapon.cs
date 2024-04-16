using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_6
{
    internal class Weapon
    {
        /*
         * name
         * attack value
         */

        string name;
        int attackValue;

        public Weapon()
        {
            name = "";
            attackValue = 1;
        }
        public Weapon(string initName, int initAttackValue)
        {
            name = initName;
            attackValue = initAttackValue;
        }
        public void SetName(string setName)
        {
            name = setName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAttackValue(int setAttackValue)
        {
            attackValue = setAttackValue;
        }

        public int GetAttackValue()
        {
            return attackValue;
        }
    }
}
