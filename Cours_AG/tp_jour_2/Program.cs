using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jour_2
{
    internal class Program
    {

        public static void EspacementDeLignes()
        {
            Console.WriteLine("\n");
        }

        public static void JeuDuPlusMoins()
        {
            // Déclaration des variables
            int inputNumber;
            int nombreTentatives = 0;
            int difficulte = 0;
            int trancheMaximale = 100;

            // Choix de la difficulté

            Console.Write("Veuillez choisir la difficulté du jeu (0 = facile, 1 = moyan, 2 = difficile) : ");
            string saisieDifficulte = Console.ReadLine();
            difficulte = int.Parse(saisieDifficulte);

            // Switch difficulté

            switch (difficulte)
            {
                case 1:
                    trancheMaximale = 1000;
                    break;
                case 2:
                    trancheMaximale = 100000;
                    break;
                default:
                    break;
            }

            // Affichage de la fourchette

            Console.WriteLine("Vous devez trouver le nombre entre 0 et " + trancheMaximale + ". C'est parti !");

            EspacementDeLignes();

            // Génération nombre aléatoire

            Random random = new Random();
            int randomNumber = random.Next(0, trancheMaximale+1);

            // Jeu du plus et du moins

            do
            {
                Console.Write("Saisissez un nombre : ");
                string inputString = Console.ReadLine();
                inputNumber = int.Parse(inputString);

                nombreTentatives += 1;

                if (inputNumber > randomNumber)
                {
                    Console.WriteLine("Plus petit.");
                }
                else if (inputNumber < randomNumber)
                {
                    Console.WriteLine("Plus grand.");
                }

            } while (randomNumber != inputNumber);

            EspacementDeLignes();

            Console.WriteLine("Vous avez trouvé le nombre en " + nombreTentatives + " tentatives. C'était bien " + inputNumber + ".");

            EspacementDeLignes();
        }

        public static bool RecommencerLeJeu()
        {
            Console.Write("Voulez vous refaire une partie (0 = non, 1 = oui) : ");
            string reponseRecommencer = Console.ReadLine();
            int numeroReponse = int.Parse(reponseRecommencer);

            bool retourAuJeu = (numeroReponse == 1);

            return retourAuJeu;
        }

        static void Main(string[] args)
        {
            // FizzBuzz

            /*for (int i = 1; i <= 100; i++) {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                } 
                else if ((i % 5 == 0) && !(i % 3 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/

            // Jeu du plus ou du moins

            bool continueDuJeu = true;

            do
            {
                Console.WriteLine("-------------------------------------------------------------------------------------");
                JeuDuPlusMoins();
                continueDuJeu = RecommencerLeJeu();
            }
            while (continueDuJeu);

            Console.ReadLine();

        }
    } 
}
