using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_events_calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar(2024, Month.novembre, 15, Day.vendredi);

            //Alert newDay = new Alert("C'est un nouveau jour.");
            //Alert newWeek = new Alert("C'est une nouvelle semaine.");
            //Alert newMonth = new Alert("C'est un nouveau mois qui commence.");
            //Alert newYear = new Alert("C'est une nouvelle année qui commence.");

            //calendar.OnNewYear += newYear.DisplayMessage;
            //calendar.OnNewMonth += newMonth.DisplayMessage;
            //calendar.OnNewWeek += newWeek.DisplayMessage;
            //calendar.OnNewDay += newDay.DisplayMessage;

            for (int i = 0; i < 90; i++)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                calendar.NextDay();
                Console.WriteLine(calendar);
                Console.WriteLine("--------------------------------------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
