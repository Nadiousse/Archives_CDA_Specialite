using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace examen_chapitre_1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //--------------------------------------------------------------------------------------------------------
            
            Dictionary<string, int> listeScoresLettres = new Dictionary<string, int>();

            listeScoresLettres.Add("aeinorstul", 1);
            listeScoresLettres.Add("dgm", 2);
            listeScoresLettres.Add("bcp", 3);
            listeScoresLettres.Add("fhv", 4);
            listeScoresLettres.Add("jq", 8);
            listeScoresLettres.Add("kwxyz", 10);

            Console.WriteLine("Veuillez saisir un mot pour connaitre son score au Scrable : ");

            string saisieMot = Console.ReadLine();
            saisieMot = saisieMot.ToLower();

            int score = 0;

            foreach (char lettre in saisieMot)
            {
                foreach (KeyValuePair<string, int> entreeDico in listeScoresLettres)
                {
                    if (entreeDico.Key.Contains(lettre))
                    {
                        score += entreeDico.Value;
                    }
                }
            }

            Console.WriteLine($"Le score de votre mot est de {score}.");

            Console.ReadLine();
        }
    }
}
