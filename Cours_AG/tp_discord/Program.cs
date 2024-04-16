using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_discord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users.Add(new User("Nadejda"));
            users.Add(new User("Thomas"));
            users.Add(new User("Margot"));
            users.Add(new User("Pierre-Louis"));
            users.Add(new User("Abdel Karim"));

            Server server = new Server("Réarmement", users);

            server.ToString();
            server.DisplayUsersList();
            server.DisplayChannelList();

            Console.ReadLine();
        }
    }
}
