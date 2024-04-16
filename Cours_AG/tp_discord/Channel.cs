using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_discord
{
    public class Channel
    {
        private string CategoryName;
        private string Name;
        public List<Message> MessagesList { get; set; }

        public Channel(string initCategoryName, string initChannelName)
        {
            this.CategoryName = initCategoryName;
            this.Name = initChannelName;

            MessagesList = new List<Message>();
            MessagesList.Add(new Message($"Le channel {Name} a été créé."));
        }

        public override string ToString()
        {
            return "(" + CategoryName + ") " + Name ;
        }

        public void DisplayAllMessages()
        {
            Tools.Separator();
            foreach (var message in MessagesList)
            {
                Console.WriteLine(message);
            }
            Tools.Separator();
        }
    }
}