using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_5_jeu_pendu
{
    internal class Program
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            // Continuer à jouer

            bool arreterLeJeu = false;
      
            do
            {
                JouerAuPendu();

                // demande si la personne veut rejouer
            } while (arreterLeJeu);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        static string ChoisirUnMot()
        {
            string motChoisi = "";
            string saisieReponseAleatoireOuSaisie;
            int saisieReponseNumero = 0;

            string[] listeDeMotsAleatoires =
            {
                "string",
                "float",
                "sharp",
                "boudin",
                "poussin",
                "ordinateur",
                "écran",
                "horaire",
                "parent",
                "école",
                "marée haute"
            };

            Console.Write("Es-tu seul ou à plusieur ? (saisir 1 pour solo, 2 pour plusieurs) ");

            do
            {
                saisieReponseAleatoireOuSaisie = Console.ReadLine();

                if (int.TryParse(saisieReponseAleatoireOuSaisie, out saisieReponseNumero))
                {
                    saisieReponseNumero = int.Parse(saisieReponseAleatoireOuSaisie);
                    continue;
                } else
                {
                    Console.Write("\nLa saisie n'est pas correcte. Veuillez resaisir le mode choisi : ");
                }

            } while (saisieReponseNumero != 1 && saisieReponseNumero != 2);

            switch (saisieReponseNumero)
            {
                case 1:
                    Random nombresAleatoires = new Random();
                    int indexAleatoire = nombresAleatoires.Next(0, listeDeMotsAleatoires.Length);

                    motChoisi = listeDeMotsAleatoires[indexAleatoire];

                    break;
                case 2:
                    Console.Write("Veuillez choisir le mot à trouver : ");

                    motChoisi = Console.ReadLine();

                    break;
            }

            return motChoisi;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        static string ConvertisseurDeMotCache(string motChoisi)
        {
            string motConverti = "";

            char[] listeDeCaracteresSpeciaux = { '\'', '/', '\"' };

            foreach (char lettre in motChoisi)
            {
                if (listeDeCaracteresSpeciaux.Contains(lettre)){
                    motConverti += lettre;
                } else
                {
                    motConverti += '*';
                }
            }

            return motConverti;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        static void JouerAuPendu()
        {
            string motADeviner = ChoisirUnMot();

            string motAffichage = ConvertisseurDeMotCache(motADeviner);

            int GagnantOuPerdant = 0;

            int nombreEssais = 0;

            do
            {
                Console.Write($"Essai numéro {nombreEssais + 1} : ");

                GagnantOuPerdant = JouerUnEssai(motADeviner, ref motAffichage);

                nombreEssais++;

                if (nombreEssais == 11)
                {
                    Console.WriteLine($"Vous avez perdu. Le mot à trouver était {motADeviner}.");
                    GagnantOuPerdant = 1;
                } else if (motAffichage == motADeviner)
                {
                    Console.WriteLine($"Bravo ! Vous avez trouver le mot {motADeviner} en {nombreEssais} essais.");
                    GagnantOuPerdant = 2;
                }

            } while (GagnantOuPerdant != 1 && GagnantOuPerdant != 2);

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        static int JouerUnEssai(string motADeviner, ref string motAffichage)
        {
            char lettreEssai;
            string saisieLettre;

            do {saisieLettre = Console.ReadLine();} while (saisieLettre.Length != 1);

            lettreEssai = char.Parse(saisieLettre);

            // vérifier si la lettre apparait dans le mot/phrase
            Dictionary<char, char> dictionnaireDesLettresAccentues = new Dictionary<char, char>
            {
                {'é', 'e'},
                {'è', 'e'},
                {'ê', 'e'},
                {'ë', 'e'},
                {'à', 'a'},
                {'â', 'a'},
                {'ä', 'a'},
                {'î', 'i'},
                {'ï', 'i'},
                {'ô', 'o'},
                {'ö', 'o'},
                {'ù', 'u'},
                {'û', 'u'},
                {'ü', 'u'},
                {'ç', 'c'},
            };

            if (dictionnaireDesLettresAccentues.ContainsValue(lettreEssai))
            {
                foreach (char lettre in motADeviner)
                {
                    
                }
            }

            // si oui, modifié l'affichage avec les lettres aux bons endroits
            // si l'affichage correspond au mot noté alors la partie est gagné
            // si le jeu arrive à tant d'essaies, alors la personne à perdu

            return 2;
        }
    }
}
