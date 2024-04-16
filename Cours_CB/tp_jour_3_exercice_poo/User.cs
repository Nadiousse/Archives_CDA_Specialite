using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_3_exercice_poo
{
    internal class User
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Language { get; set; }
        public DateTime Date { get; set; }

        public User()
        {
            Name = "";
            FirstName = "";
            Language = "english";
            Date = DateTime.Now;
        }

        public User(string initName, string initFirstName)
        {
            Name = initName;
            FirstName = initFirstName;
            Language = "english";
            Date = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine("Nom : " + Name);
            Console.WriteLine("Prénom : " + FirstName);
            Console.WriteLine("Date de création : " + Date);
        }

        public string ChangeLanguage(string newLanguage)
        {
            Language = newLanguage;
            return ($"Le language a été modifié à '{Language}'.");
        }
    }
}
