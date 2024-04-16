using System.Linq.Expressions;

namespace partie_a_examen_chapitre_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fourmiliere experience = new Fourmiliere(500);

            experience.Proliferer(12);

            Console.WriteLine($"Après 12 jours, il y a {experience.Population} de fourmis dans la fourmilière.");
        }
    }
}
