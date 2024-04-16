using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_6
{
    internal class Armor
    {
        /*
         * name
         * protection value
         */

        string name;
        int protectionValue;

        public Armor()
        {
            name = "";
            protectionValue = 1;
        }
        public Armor(string initName, int initProtectionValue)
        {
            name = initName;
            protectionValue = initProtectionValue;
        }

        public void SetName(string setName)
        {
            name = setName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetProtectionValue(int setProtectionValue)
        {
            protectionValue = setProtectionValue;
        }

        public int GetProtectionValue()
        {
            return protectionValue;
        }
    }
}
