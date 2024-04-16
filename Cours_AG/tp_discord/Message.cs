using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_discord
{
    public class Message
    {
        private DateTime MessageDateTime { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public User User { get; set; }
        public string FullMessage { get; set; }

        public Message(string initMessage)
        {
            MessageDateTime = DateTime.Now;
            FullMessage = initMessage;
            User = null;

            Time = MessageDateTime.ToString("HH:mm");
            Date = MessageDateTime.ToString("dd/MM/yyyy");
        }

        public Message(string initMessage, User initUser)
        {
            MessageDateTime = DateTime.Now;
            FullMessage = initMessage;
            User = initUser;
        }

        public override string ToString()
        {
           return Time + " - " + FullMessage;
        }
    }
}