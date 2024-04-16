using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_2_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Faire une liste de chiffres qui représentent le nombre de points de vie qu'ont des personnages.
            //On fait une requête LINQ pour obtenir seulement les personnages qui ont plus de 20 point de vie

            /*int[] tableauPointDeVie = { 50, 60, 20, 5, 10, 90, 30, 45, 0, 10 };

            var numQuerry =
                from pointDeVie in tableauPointDeVie
                where pointDeVie > 20
                select pointDeVie;

            foreach (int pVie in numQuerry)
            {
                Console.Write($"{pVie} ");
            }*/

            //--------------------------------------------------------------------------------------------------------

            /*Write a program in C# Sharp to show how the three parts of a query operation execute.
                Expected Output:
                The numbers which produce the remainder 0 after divided by 2 are :
                0 2 4 6 8*/

            /*int[] numberList = { 0, 5, 20, 5, 3, 4, 9, 66, 12, 34, 88, 90 };

            var numeroDivisiblePar2 =
                from numero in numberList
                where numero % 2 == 0
                select numero;

            foreach (int numero in numeroDivisiblePar2)
            {
                Console.Write($"{numero} ");
            }*/

            //--------------------------------------------------------------------------------------------------------

            /*2. Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
                Expected Output:
                The numbers within the range of 1 to 11 are :
                1 3 6 9 10*/

            /*int[] listeDeNombresPositifEtNegatifs = { -1, 0, 6, 8, -10, -6, 3, 5, -8 };

            var numerosPositifs =
                from numeroPositif in listeDeNombresPositifEtNegatifs
                where numeroPositif >= 0
                where numeroPositif < 12
                select numeroPositif;

            foreach (int numeroPositif in numerosPositifs)
            {
                Console.Write($"{numeroPositif} ");
            }*/

            Console.ReadLine();

        }
    }
}
