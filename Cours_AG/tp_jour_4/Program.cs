using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP__Jour_4
{
    internal class Program
    {
        public static void EspacementEntreLesLignes()
        {
            Console.WriteLine("\n");
        }

        // Niveau 1 : Faire une fonction qui calcule l'aire d'un rectangle

        /*public static float AireRectangle()
        {
            Console.Write("Saisissez la longueur : ");
            string saisieLongueur = Console.ReadLine();
            int longueur = int.Parse(saisieLongueur);

            Console.Write("Saisissez la largeur : ");
            string saisieLargeur = Console.ReadLine();
            int largeur = int.Parse(saisieLargeur);

            return longueur * largeur;
        }*/

        // Niveau 2 : Faire une fonction qui répète x fois un message dans la console

        /*public static void EnvoiMessage()
        {
            Console.Write("Saisissez le nombre de répétitions du message : ");
            string saisieRepetitions = Console.ReadLine();
            int nombreDeRepetitions = int.Parse(saisieRepetitions);

            for (int i = 0; i < nombreDeRepetitions; i++)
            {
                Console.WriteLine("Ceci est un message.");
            }
        }*/

        // Niveau 3 : Faire une fonction exposant

        /* public static int renvoiExposant(int chiffre, int exposant)
         {
             int total = 1;

             for (int i = 0; i < exposant; i++)
             {
                 total *= chiffre;
             }

             return total;
         }*/

        //Tableau niveau 2 :
        public static float MoyenneTableau(int[] tableau)
        {
            float total = 0f;
            if (tableau.Length == 0)
            {
                return 0f;
            }
            else
            {
                for (int i = 0; i < tableau.Length; i++)
                {
                    total += tableau[i];
                }
                return total / tableau.Length;
            }
        }

        // Tableaux niveau 3 :

        public static void AffichageGrilleJeu(string[,] tableau) {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tableau[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static string TraducteurDeMot(Dictionary<string, string> tableau, string motATraduire) 
        {
            foreach (KeyValuePair<string, string> itemDuDictionnaire in tableau)
            {
                if (itemDuDictionnaire.Key == motATraduire)
                { 
                    return itemDuDictionnaire.Value;
                }
            }

            return null;
        }


        static void Main(string[] args)
        {
            // Niveau 1

            /*Console.WriteLine("L'aire du rectangle est de " + AireRectangle() + ".");

            EspacementEntreLesLignes();

            // Niveau 2

            EnvoiMessage();

            EspacementEntreLesLignes();

            // Niveau 3 : Faire une fonction exposant

            Console.Write("Saisissez le nombre à multiplier : ");
            string saisieNombre = Console.ReadLine();
            int nombreAMultiplier = int.Parse(saisieNombre);

            Console.Write("Saisissez l'exposant : ");
            string saisieExposant = Console.ReadLine();
            int nombreExposant = int.Parse(saisieExposant);

            Console.WriteLine(renvoiExposant(nombreAMultiplier, nombreExposant));*/

            //-----------------------------------------------------------------------------------------------------------

            // Exercices Tableaux + Collections

            // Tableaux
            // Niveau 1 : Faire un tableau qui contient des prénoms et les afficher tous dans la console

            /* string[] tableauNoms = { "Théo", "Thomas", "Margot", "Lilian", "Pierre-Louis", "Nicolas", "Nordine"};

            foreach (string prenom in tableauNoms)
            {
                Console.WriteLine(prenom);
            }

            Console.ReadLine();
            EspacementEntreLesLignes();*/

            //Niveau 2 : Faire une fonction qui prend en paramètre un tableau et renvoie la moyenne des valeurs

            /*int[] tableauValeursPourMoyenne = { 3, 100, 55, 20, 33, 17, 64, 58, 48, 13, 39 };

            Console.WriteLine(MoyenneTableau(tableauValeursPourMoyenne));

            Console.ReadLine();
            EspacementEntreLesLignes();*/

            //Niveau 3 : Faire un jeu sur lequel on peut déplacer un personnage sur une grille

            /*string[,] grilleJeuDeplacements =
            {
                {"╔", "═", "═", "═", "═", "═", "╦", "═", "═", "╗"},
                {"║", " ", " ", " ", " ", " ", "║", " ", " ", "║"},
                {"║", " ", "═", "═", "═", "═", "╝", " ", " ", "║"},
                {"║", " ", " ", " ", " ", " ", " ", " ", " ", "║"},
                {"╠", "═", "═", "═", "═", "═", "═", "═", " ", "║"},
                {"║", " ", " ", " ", " ", " ", " ", " ", " ", "║"},
                {"║", " ", "═", "═", "═", "═", "═", "╦", "═", "╣"},
                {"║", " ", " ", " ", " ", " ", " ", "║", "X", "║"},
                {"║", " ", " ", " ", " ", " ", " ", " ", " ", "║"},
                {"╚", "═", "═", "═", "═", "═", "═", "═", "═", "╝"}
            };

            string entreeDeplacement;
            bool finDeJeu = true;
            int xPersonnage = 8;
            int yPersonnage = 9;
            int xDeplacement = 0;
            int yDeplacement = 0;

            char[] limites = { "╔", "║", "╠", "╚", "═", "╝", "╣", "╗", "╦"};

            do
            {
                AffichageGrilleJeu(grilleJeuDeplacements);
                do
                {
                    entreeDeplacement = Console.ReadLine();

                    if (entreeDeplacement == "sortir")
                    {
                        finDeJeu = false;
                        break;
                    }

                    if (entreeDeplacement != "zqsd")
                    {
                        break;
                    }

                    switch (entreeDeplacement)
                    {
                        case "z":
                            yDeplacement -= 1;
                            break;
                        case "q":
                            xDeplacement -= 1;
                            break;
                        case "s":
                            yDeplacement += 1;
                            break;
                        case "d":
                            xDeplacement += 1;
                            break;
                    }


                    
                } while (true);

                

            } while (finDeJeu);*/


            // Collections
            // Niveau 1 : Faire une liste qui représente des personnes dans un canal vocal, ajouter quelques personnes et afficher tout le monde. On peut ensuite retirer une personne et réafficher la nouvelle liste

            /* List<string> personnesPresentesVocal = new List<string>();

             personnesPresentesVocal.Add("Thomas");
             personnesPresentesVocal.Add("Pierre-Louis");
             personnesPresentesVocal.Add("Nadejda");
             personnesPresentesVocal.Add("Margot");
             personnesPresentesVocal.Add("Nordine");
             personnesPresentesVocal.Add("Abdel Karim");

             Console.WriteLine("Personnes présentes au vocal : ");

             foreach (string prenomPersonne in personnesPresentesVocal)
             {
                 Console.WriteLine(prenomPersonne);
             }

             EspacementEntreLesLignes();
             Console.ReadLine();

             Console.WriteLine(personnesPresentesVocal[3] + " est sortie de la conversation.");

             EspacementEntreLesLignes();
             Console.ReadLine();

             personnesPresentesVocal.RemoveAt(3);

             Console.WriteLine("Personnes présentes au vocal : ");

             foreach (string prenomPersonne in personnesPresentesVocal)
             {
                 Console.WriteLine(prenomPersonne);
             }*/


            //Niveau 2 : Faire deux listes une de noms, une de prenoms, puis faire un generateur qui associe un nom et un prenom de manière aleatoire

            List<string> noms = new List<string>();
            List<string> prenoms = new List<string>();

            noms.Add("Dupont");
            noms.Add("Dubois");
            noms.Add("Dupays");
            noms.Add("Ducon");
            noms.Add("Duchamps");
            noms.Add("Dumachin");

            prenoms.Add("Jean-Jacques");
            prenoms.Add("Jean-Michel");
            prenoms.Add("Jean-Pierre");
            prenoms.Add("Jean-Batiste");
            prenoms.Add("Jean-Arthur");
            prenoms.Add("Jean-Robert");

            Random random = new Random();

            int randomNumberOne = random.Next(0, 5);

            string nomRandom = noms[randomNumberOne];

            int randomNumberTwo = random.Next(0, 5);

            string prenomRandom = prenoms[randomNumberTwo];

            Console.WriteLine(nomRandom + " "+ prenomRandom);

            // Niveau 3 : Faire un (ou plusieurs) dictionnaire qui prend comme clé un mot dans une langue et en valeur ce même mot dans une autre langue. 

            /*Dictionary<string, string> dictionnaireFrancaisAnglais = new Dictionary<string, string>();

            dictionnaireFrancaisAnglais.Add("Bonjour", "Hello");
            dictionnaireFrancaisAnglais.Add("Comment ca va ?", "How are you ?");
            dictionnaireFrancaisAnglais.Add("Couleur", "Colour");
            dictionnaireFrancaisAnglais.Add("Trou", "Hole");
            dictionnaireFrancaisAnglais.Add("Nain", "Dwarf");
            dictionnaireFrancaisAnglais.Add("Arbre", "Tree");

            // Niveau 3,5 : Faire une fonction qui prend en paramètre un de ces dictionnaire ainsi qu'un mot et qui renvoie ce mot traduit par ce dictionnaire (si on lui passe "Hello" et un dictionnaire Anglais-Français, ça renvoie "Bonjour")

            string saisieMotATraduire = Console.ReadLine();

            Console.WriteLine(TraducteurDeMot(dictionnaireFrancaisAnglais, saisieMotATraduire));*/

            Console.ReadLine();
        }
    }
}
