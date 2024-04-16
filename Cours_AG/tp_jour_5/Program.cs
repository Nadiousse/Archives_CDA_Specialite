using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* S'entraîner avec les ref et out.
             * Entrée un nombre de secondes. Faire une fonction qui converti les secondes en secondes, minutes, heures.*/

            /*int secondes = 0;
            int minutes = 0;
            int heures = 0;

            Console.Write("Veuillez saisir le nombre de secondes : ");

            string saisieSecondes = Console.ReadLine();
            secondes = int.Parse(saisieSecondes);

            ConvertirEnHeuresMinutesSecondes(ref secondes, ref minutes, ref heures);

            Console.WriteLine($"{heures} heures, {minutes} minutes, {secondes} secondes.");*/

            //---------------------------------------------------------------------------------------------------------------

            /*  Manipulation de Chaînes de caractère:
                Niveau 1 : Faire une fonction pour brouiller un message qui change toutes les voyelles d'une chaîne de caractère en "x"*/

            /*string messageACoder =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

            Console.WriteLine(BrouillerLeString(messageACoder));*/

            //---------------------------------------------------------------------------------------------------------------

            /*Niveau 2 : Faire une fonction de cryptage. Elle possède un dictionnaire à l'intérieur d'elle qu'on va utiliser pour modifier chaque lettre en une autre*/

            Dictionary<char, char> dictionnaireDeCryptage = new Dictionary<char, char>()
            {
                { 'a', 'j' },
                { 'e', 'd' },
                { 'y', 'x' },
                { 'u', 'p' },
                { 'i', 'q' },
                { 'o', 'c' },
                { 'l', 'r' },
                { 'r', 'v' },
                { 't', 'k' },
            };

            string messageSaisie = Console.ReadLine();

            messageSaisie = messageSaisie.ToLower();

            Console.WriteLine(CrypterUnMessage(messageSaisie, dictionnaireDeCryptage));

            Console.ReadLine();
        }

        static string CrypterUnMessage(string messageACrypter, Dictionary<char,char> dictionnaire)
        {
            string messageCrypte = "";

            foreach (char lettre in messageACrypter)
            {
                if (dictionnaire.ContainsKey(lettre))
                {
                    messageCrypte += dictionnaire[lettre];
                }
                else
                {
                    messageCrypte += lettre;
                }
            }

            return messageCrypte;
        }

        static string BrouillerLeString(string messageABrouiller)
        {
            string messageCode = "";

            foreach (char lettre in messageABrouiller)
            {
                if ("aeyuio".Contains(lettre)){
                    messageCode += "x";
                } else
                {
                    messageCode += lettre;
                }
            }

            return messageCode;
        }

        static void ConvertirEnHeuresMinutesSecondes(ref int sec, ref int min, ref int heure)
        {

            if (sec >= 60)
            {
                min = sec / 60;
                sec %= 60;

                if (min >= 60)
                {
                    heure = min / 60;
                    min %= 60;
                }
            }
        }
    }
}
