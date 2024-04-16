using System;

namespace _Cours_Jour1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool leJeuContinue = true;

            do
            {
                UnTempsDeJeu();

                leJeuContinue = ContinuerLeJeuOuArreter();

            } while (leJeuContinue);

            Console.ReadLine();
        }

        public static bool ContinuerLeJeuOuArreter()
        {
            string saisieContinueOuFin = "non";

            Console.Write("Voulez-vous rejouer ? Marquez 'oui' pour continuer sinon entrez 'non' pour quitter. ");
            do
            {
                saisieContinueOuFin = Console.ReadLine();
                saisieContinueOuFin = saisieContinueOuFin.ToLower();
            } while (saisieContinueOuFin != "oui" && saisieContinueOuFin != "non");

            if (saisieContinueOuFin == "non")
            {
                Console.WriteLine("Merci d'avoir joué.");
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }
        public static int RechercherBonusMalusCase(int caseActuelleDuJoueur)
        {
            switch (caseActuelleDuJoueur)
            {
                case 2:
                    Console.WriteLine("Le joueur a trouvé un escalier. Il monte à la case 17.");
                    return 17;
                case 14:
                    Console.WriteLine("Le joueur a trouvé un serpent. Il descent à la case 7.");
                    return 7;
                case 20:
                    Console.WriteLine("Le joueur a trouvé un escalier. Il monte à la case 35.");
                    return 35;
                case 31:
                    Console.WriteLine("Le joueur a trouvé un escalier. Il monte à la case 43.");
                    return 43;
                case 37:
                    Console.WriteLine("Le joueur a trouvé un serpent. Il descent à la case 12.");
                    return 12;
                case 46:
                    Console.WriteLine("Le joueur a trouvé un serpent. Il descent à la case 33.");
                    return 33;
                default:
                    return caseActuelleDuJoueur;
            }
        }
        public static bool GagnerOuPas(int joueurDontLeTour, int caseDuJoueurDontLeTour)
        {
            if (caseDuJoueurDontLeTour == 50)
            {
                Console.WriteLine($"Le jeu est fini. Le joueur {joueurDontLeTour} a gagné.");
                Console.ReadLine();
                return true;
            }
            else { return false; }
        }
        public static void UnTempsDeJeu()
        {
            int[] casesDesJoueurs = { 1, 1 };

            bool finDuJeu = false;

            Console.WriteLine("Le jeu commence. Les deux joueurs sont sur la case un pour commencer.\n\n");

            do
            {
                for (int i = 1; i <= 2; i++)
                {
                    casesDesJoueurs[i-1] = TempsDuJoueur(i, casesDesJoueurs[i-1]);

                    finDuJeu = GagnerOuPas(i, casesDesJoueurs[i - 1]);

                    if (finDuJeu == true) { break; }

                    Console.ReadLine();
                }

                Console.Clear();

            } while (!finDuJeu);
        }

        public static int TempsDuJoueur(int numeroJoueur, int caseActuelleJoueur)
        {
            Random desDe6 = new Random();
            int deplacement;

            Console.WriteLine($"Le joueur {numeroJoueur} joue.");
            Console.WriteLine($"Le joueur {numeroJoueur} est actuelement sur la case {caseActuelleJoueur}.\n");

            deplacement = desDe6.Next(1, 7);
            Console.WriteLine($"Résultat Dés : {deplacement}");

            if (caseActuelleJoueur + deplacement > 50)
            {
                caseActuelleJoueur = 25;
            }
            else { caseActuelleJoueur += deplacement; };

            caseActuelleJoueur = RechercherBonusMalusCase(caseActuelleJoueur);

            Console.WriteLine($"Le joueur {numeroJoueur} se déplace vers la case {caseActuelleJoueur}.\n\n");

            return caseActuelleJoueur;
        }
    }
}
