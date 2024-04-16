using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_7_bibliotheque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book seigneurDesAnneaux = new Book("Seigneur des Anneaux", "J.R.R Tolkien", Genre.adventure, 700);
            Database.InitializeBooks(seigneurDesAnneaux);

            Book harryPotter = new Book("Harry Potter", "J.K. Rollings", Genre.fantasy, 400);
            Database.InitializeBooks(harryPotter);

            Book queteDEwilan = new Book("La Quête d'Ewilan", "Pierre Bottero", Genre.teen, 300);
            Database.InitializeBooks(queteDEwilan);

            Book noirDemon = new Book("Noir Demon", "Suzanne Wright", Genre.romance, 400);
            Database.InitializeBooks(noirDemon);

            Book psiChangeling = new Book("Psi-Changeling", "Nalini Singh", Genre.science_fiction, 500);
            Database.InitializeBooks(psiChangeling);

            Book Dracula = new Book("Dracula", "Bram Stoker", Genre.horror, 600);
            Database.InitializeBooks(Dracula);

            Book shining = new Book("Shining", "Stephen King", Genre.horror, 500);
            Database.InitializeBooks(shining);

            Book dune = new Book("Dune", "Frank Herbert", Genre.science_fiction, 700);
            Database.InitializeBooks(dune);

            Database.DisplayBooks();

            Database.DisplayBooks(Genre.horror);

            Database.DisplayBooks("an");

            Console.ReadLine();
            Console.Clear();

            User userOne = new User("Nadejda", "Teriokhina");

            userOne.BorrowBook(noirDemon);
            userOne.BorrowBook(psiChangeling);
            userOne.BorrowBook(queteDEwilan);
            userOne.DisplayBorrowedBooks();

            Database.DisplayAvailableBooks();
            
            Console.ReadLine();
            Console.Clear();

            userOne.UnborrowBook(psiChangeling);
            userOne.DisplayBorrowedBooks();

            Console.ReadLine();
        }
    }
}
