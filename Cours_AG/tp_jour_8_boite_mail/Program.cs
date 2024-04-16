using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_8_boite_mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User nadejda = new User("Nadejda", "TERIOKHINA");
            User thomas = new User("Thomas", "Thouvenin");

            nadejda.SendMail(thomas);

            Console.ReadLine();
            Console.Clear();

            thomas.DisplayUnreadMails();
            thomas.ReadAnUnreadEmailInboxMail();

            Console.ReadLine();
            Console.Clear();
        }
    }
}
