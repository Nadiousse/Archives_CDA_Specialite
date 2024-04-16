using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_discord
{
    public class Server
    {
        public string ServerName { get; set; }
        public List<User> UserList { get; set; }
        public List<Channel> ChannelList { get; set; }

        public Server(string initName, List<User> initUserList) 
        {
            ServerName = initName;

            UserList = new List<User>();
            UserList = initUserList;

            ChannelList = new List<Channel>();
            ChannelList.Add(new Channel("Général", "Discussion"));
        }

        public void DisplayChannelList()
        {
            Tools.Separator();
            Console.WriteLine($"Serveur Actuel : {ServerName}");
            foreach (Channel channel in ChannelList)
            {
                Console.Write("- ");
                Console.WriteLine(channel);
            }
            Tools.Separator();
        }

        public void DisplayUsersList()
        {
            Tools.Separator();
            Console.WriteLine($"Utilisateurs : {ServerName}");
            foreach (User user in UserList)
            {
                Console.Write("- ");
                Console.WriteLine(user);
            }
            Tools.Separator();
        }
    }
}