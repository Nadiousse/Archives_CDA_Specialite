using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables

            // Exercice 1 :

            /*La machine nous demande "comment tu t'appelles ?", on lui indique notre prénom et 
             * elle répond "Bonjour [insérer ici notre prénom] */

            Console.WriteLine("Veuillez saisir votre nom : ");

            string nom = Console.ReadLine();

            Console.WriteLine("Bonjour " + nom + "!" + "\n\n");

            // Exercice 2 :

            /*On entre deux nombres dans la machine et elle nous indique la somme de ces deux nombres*/

            Console.WriteLine("Veuillez saisir un nombre entier : ");

            string saisie1 = Console.ReadLine();

            int a = int.Parse(saisie1);

            Console.WriteLine("Veuillez saisir un nombre entier : ");

            string saisie2 = Console.ReadLine();

            int b = int.Parse(saisie2);

            Console.WriteLine("La somme des deux entiers saisis est : " + (a + b) + "\n\n");

            // Exercice 3 :

            /*On indique un prix et un pourcentage de réduction à la machine et elle nous indique le nouveau prix
            *(par exemple un objet coûtant 100€ étant à 20% de réduction coûte au final 80€)*/

            int prix;
            int pourcentage;
            float réduction;
            float total;

            Console.WriteLine("Veuillez saisir le prix du produit : ");

            string saisie3 = Console.ReadLine();

            prix = int.Parse(saisie3);

            Console.WriteLine("Veuillez saisir le pourcentage de réduction : ");

            string saisie4 = Console.ReadLine();

            pourcentage = int.Parse(saisie4);

            réduction = prix * pourcentage / 100;

            total = prix - réduction;

            Console.WriteLine("Le prix à la caisse du produit est : " + total + " euros.");
            Console.ReadLine();




            // Conditions //

            /*Niveau 1 : Demander l'âge
             *La machine nous demande notre âge et selon ce qu'on répond elle nous indique un message différent*/

            Console.WriteLine("Veuillez saisir votre âge : ");
            string saisieAge = Console.ReadLine();

            int age = int.Parse(saisieAge);

            if (age <= 17) {
                Console.WriteLine("Vous êtes mineurs.");
            } else if (18 <= age && age <= 30) {
                Console.WriteLine("Vous êtes jeunes.");
            } else if (31 <= age && age <= 80) {
                Console.WriteLine("Vous êtes vieux.");
            } else if (age >= 80) { 
                Console.WriteLine("Que faites vous encore ici ?");
            }

            /*Niveau 2 : 3 nombres croissants
             * On entre 3 nombres les uns après les autres dans la machine et elle nous indique si on a 
             * bien entré des nombres dans l'ordre croissant*/

            Console.WriteLine("Veuillez saisir le premier chiffre : ");
            string saisieN1 = Console.ReadLine();
            int x = int.Parse(saisieN1);

            Console.WriteLine("Veuillez saisir le deuxième chiffre : ");
            string saisieN2 = Console.ReadLine();
            int y = int.Parse(saisieN2);

            Console.WriteLine("Veuillez saisir le troisième chiffre : ");
            string saisieN3 = Console.ReadLine();
            int z = int.Parse(saisieN3);

            if (x <= y && y <= z)
            {
                Console.WriteLine("Les chiffres sont dans l'ordre croissant.");
            }
            else if (z <= y && y <= x)
            {
                Console.WriteLine("Les chiffres sont dans l'ordre décroissant.");
            }
            else
            {
                Console.WriteLine("Les chiffres sont dans le désordre.");
            }


            /*Niveau 3 : Difficulté d'un boss
             * On indique quel niveau de difficulté on veut pour un boss et selon la difficulté le nombre de PV du boss affiché 
             * dans la console est différent*/

            Console.WriteLine("Veuillez saisir le niveau du Boss (un chiffre entre 1 et 5) : ");
            string saisieN4 = Console.ReadLine();
            int niveau = int.Parse(saisieN4);

            switch (niveau)
            {
                case 1:
                case 2:
                    Console.WriteLine("Le Boss a 100 points de vie.");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Le Boss a 1000 points de vie.");
                    break;
                default:
                    Console.WriteLine("Le bos a 10 000 points de vie. Bon courage.");
                    break;
            }

            // Boucles //

            // Niveau 1 : Afficher les chiffres de 0 à 1000 dans la console

            for (int i = 0; i <= 1000; i++)
            {
                Console.Write(i + " ");
                if (i % 100 == 0)
                {
                    Console.WriteLine("");
                }
            }

            // Niveau 2 : La machine nous demande d'entrer une lettre dans la console jusqu'à ce qu'on ait rentré la lettre a

            string lettreSaisie1;
            
            do
            {
                Console.WriteLine("Veuillez saisir une lettre : ");
                lettreSaisie1 = Console.ReadLine();
            } while (lettreSaisie1 != "a");

            // Niveau 3 : Idem mais jusqu'à ce qu'on ait rentré une voyelle

            string lettreSaisie2;

            while (true) {
                Console.WriteLine("Veuillez saisir une voyelle : ");
                lettreSaisie2 = Console.ReadLine();

                if (lettreSaisie2 == "a" || lettreSaisie2 == "e" || lettreSaisie2 == "y" || lettreSaisie2 == "u" || lettreSaisie2 == "i" || lettreSaisie2 == "o")
                {
                    break;
                }
            }

            Console.ReadLine();
        }

    }
}
