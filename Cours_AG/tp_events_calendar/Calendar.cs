using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace tp_events_calendar
{
    public class Calendar
    {
        public int Year { get; set; }
        public Month Month { get; set; }
        private int Week { get; set; }
        public int DayNumber { get; set; }
        public Day Day { get; set; }

        public delegate void Display();
        public event Display OnNewDay;
        public event Display OnNewWeek;
        public event Display OnNewMonth;
        public event Display OnNewYear;

        public Calendar(int year, Month month, int dayNumber, Day day)
        {
            Year = year;
            Month = month;
            DayNumber = dayNumber;
            Day = day;
        }

        public void NextDay()
        {
            if (Day == Day.dimanche)
            {

                Day = Day.lundi;
                Week += 1;

                if (OnNewWeek != null)
                {
                    OnNewWeek();
                }

                if (Week == 52)
                {
                    Week = 1;
                } else
                {
                    Week += 1;
                }
                
            } 
            else 
            { 
                Day++;
            }

            if (DayNumber >= 30) 
            {
                DayNumber = 1;

                if (Month == Month.décembre)
                {
                    Month = Month.janvier;

                    Year++;

                    if (OnNewMonth != null)
                    {
                        OnNewYear();
                    }
                }
                else 
                { 
                    Month++;
                    if (OnNewMonth != null)
                    {
                        OnNewMonth();
                    }
                }
            } 
            else 
            { 
                DayNumber++; 

                if (OnNewDay != null)
                {
                    OnNewDay();
                }
                
            }
        }

        public override string ToString()
        {
            return Day.ToString() + " " + DayNumber + " " + Month.ToString() + " " + Year + " : ";
        }
    }
}