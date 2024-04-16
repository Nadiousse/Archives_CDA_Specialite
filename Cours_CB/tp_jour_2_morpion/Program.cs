using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_2_morpion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finDuJeu = false;


            //Jeu

            do
            {
                AfficherReglesDuJeu();

                finDuJeu = ArrêterOuContinuer();
                if (finDuJeu == true)
                {
                    Console.Clear();
                }

            } while (!finDuJeu);
        }

        static void AfficherReglesDuJeu()
        {
            Console.WriteLine("Veuillez choisir dans quelle case mettre votre symbole.");

            string[,] plateauDuMorpionExemple =
            {
                {"1", "|" , "2","|" , "3" },
                {"-", "|" , "-","|" , "-" },
                {"4", "|" , "5","|" , "6" },
                {"-", "|" , "-","|" , "-" },
                {"7", "|" , "8","|" , "9" },
            };

            AfficherTableau(plateauDuMorpionExemple);
           
            Console.WriteLine("----------------------------------------------------------------------------------");
        }

        static void AfficherTableau(string[,] tableau)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tableau[i, j]);
                }
                Console.WriteLine("");
            }
        }

        static bool ArrêterOuContinuer()
        {
            string saisieEnMinuscule = "non";

            Console.Write("Voulez vous continuer de jouer ? ");

            string saisieFinOuContinue = Console.ReadLine();
            saisieEnMinuscule = saisieFinOuContinue.ToLower();

            if (saisieFinOuContinue == "oui")
            {
                return false;
            }else { return true; }
        }

        static void JouerAuMorpion()
        {
            bool yaUnGagnant = false;

            string[,] plateauDuMorpion =
            {
                {" ", "|" , " ","|" , " " },
                {"-", "|" , "-","|" , "-" },
                {" ", "|" , " ","|" , " " },
                {"-", "|" , "-","|" , "-" },
                {" ", "|" , " ","|" , " " },
            };

            do
            {
                AfficherTableau(plateauDuMorpion);
            } while (!yaUnGagnant);
        }
    }
}
