using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_events_calendar
{
    public class AlertArgs : EventArgs
    {
        public int Year { get; set; }
        public Month Month { get; set; }
        public int Week { get; set; }
        public int DayNumber { get; set; }
        public Day Day { get; set; }
    }
}