using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_events_calendar
{
    public class Alert
    {
        public string Message { get; set; }

        public Alert(string message)
        {
            Message = message;
        }

        public void DisplayMessage()
        {
            Console.WriteLine(Message);
        }
    }
}