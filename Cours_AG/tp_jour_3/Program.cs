using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TP__Jour_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombreLignesParProgramme = 0;
            string chaineDemandeNombreLignes = "Veuillez saisir le nombre de lignes d'itération : ";
            string caractereSortie = "*";


            // Level 0 :


            /*Console.Write(chaineDemandeNombreLignes);
            string saisiNombreLignes = Console.ReadLine();
            nombreLignesParProgramme = int.Parse(saisiNombreLignes);

            for (int i = 0; i < nombreLignesParProgramme; i++)
            {
                Console.WriteLine(caractereSortie);
            }*/


            // Level 1


            /*Console.Write(chaineDemandeNombreLignes);
            string saisiNombreLignes = Console.ReadLine();
            nombreLignesParProgramme = int.Parse(saisiNombreLignes);

            for (int i = 0; i < nombreLignesParProgramme; i++)
            {
                for (int j = 0; j < nombreLignesParProgramme; j++)
                {
                    Console.Write(caractereSortie);
                }
                Console.WriteLine("");
            }*/


            // Level 2


            /*Console.Write(chaineDemandeNombreLignes);
            string saisiNombreLignes = Console.ReadLine();
            nombreLignesParProgramme = int.Parse(saisiNombreLignes);

            for (int i = 0; i < nombreLignesParProgramme; i++)
            {
                int nombreCaracteresParLigne = nombreLignesParProgramme - nombreLignesParProgramme + i + 1;

                for (int j = 0; j < nombreCaracteresParLigne; j++)
                {
                    Console.Write(caractereSortie);
                }
                Console.WriteLine();
            }*/


            // Level 3


            Console.Write(chaineDemandeNombreLignes);
            string saisiNombreLignes = Console.ReadLine();
            nombreLignesParProgramme = int.Parse(saisiNombreLignes);

            for (int i = 1; i <= nombreLignesParProgramme; i++)
            {
                for (int k = 1; k <= (nombreLignesParProgramme - i); k++)
                {
                    Console.Write(" ");
                }

                for (int l = 1; l <= (i * 2); l++)
                {
                    Console.Write(caractereSortie);
                }

                for (int m = 1; m <= (nombreLignesParProgramme - i); m++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("");
            }*/


            // Level 4


            Console.Write(chaineDemandeNombreLignes);
            string saisiNombreLignes = Console.ReadLine();
            nombreLignesParProgramme = int.Parse(saisiNombreLignes);

            for (int i = 1; i <= nombreLignesParProgramme; i++)
            {
                bool lignePairImpaire = (i % 2 == 0);

                if (lignePairImpaire)
                {
                    for (int j = 1; j <= nombreLignesParProgramme; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        if (j % 2 == 1) 
                        { 
                            Console.Write(" "); 
                        }
                    }
                    Console.WriteLine();
                }

                if (!lignePairImpaire)
                {
                    for (int k = 1; k <= nombreLignesParProgramme; k++)
                    {
                        if (k % 2 == 0)
                        {
                            Console.Write(" ");
                        }
                        if (k % 2 == 1)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
