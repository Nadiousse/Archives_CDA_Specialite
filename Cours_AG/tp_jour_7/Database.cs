using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_7_bibliotheque
{
    internal class Database
    {
        static List<Book> AllBooks = new List<Book>();
        static List<Book> AvailableBooks = new List<Book>();

        static public void InitializeBooks(Book initBook)
        {
            Database.AllBooks.Add(initBook);
            Database.AvailableBooks.Add(initBook);
        }

        static public void AddAvailableBook(Book book)
        {
            AvailableBooks.Add(book);
        }
        static public void RemoveAvailableBook(Book book)
        {
            AvailableBooks.Remove(book);
        }

        static public void DisplayAvailableBooks()
        {
            Console.WriteLine("\nVoici la liste de livre actuellement disponibles à la bibliothèque : ");
            foreach (Book book in AvailableBooks)
            {
                Console.WriteLine($"- {book.Title}, {book.Autor}, {book.Genre}, {book.NumberOfPages} pages.");
            }
        }

        static public void DisplayBooks()
        {
            Console.WriteLine("\nVoici la liste totale de livre possédés par la bibliothèque : ");
            foreach (Book book in AllBooks)
            {
                Console.WriteLine($"- {book.Title}, {book.Autor}, {book.Genre}, {book.NumberOfPages} pages.");
            }
        }

        static public void DisplayBooks(Genre genre)
        {
            Console.WriteLine($"\nVoici la liste de livre actuellement possédé par la bibliothèque du genre {genre} : ");
            foreach (Book book in AllBooks)
            {
                if (book.Genre == genre)
                {
                    Console.WriteLine($"- {book.Title}, {book.Autor}, {book.NumberOfPages} pages.");
                }
            }
        }

        static public void DisplayBooks(string autorOrTitle)
        {
            Console.WriteLine($"\nVoici la liste de livre actuellement possédé par la bibliothèque qui contient '{autorOrTitle}' : ");
            foreach (Book book in AllBooks)
            {
                if (book.Autor.Contains(autorOrTitle) || book.Title.Contains(autorOrTitle))
                {
                    Console.WriteLine($"- {book.Title}, {book.Autor}, {book.Genre}, {book.NumberOfPages} pages.");
                }
            }
        }
    }
}
