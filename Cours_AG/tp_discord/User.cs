using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_discord
{
    public class User
    {
        public string UserName { get; set; }

        public User(string initName)
        {
            UserName = initName;
        }

        public override string ToString()
        {
            return UserName;
        }
    }
}