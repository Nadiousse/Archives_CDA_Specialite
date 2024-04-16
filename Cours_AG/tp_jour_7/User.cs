using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_7_bibliotheque
{
    internal class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public User(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;

            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
            Database.RemoveAvailableBook(book);
            Console.WriteLine($"Le livre '{book.Title}' a été empreinté aujourd'hui par {this.Firstname} {this.Lastname}.");
        }

        public void UnborrowBook(Book book)
        {
            BorrowedBooks.Remove(book);
            Database.AddAvailableBook(book);
            Console.WriteLine($"Le livre '{book.Title}' a été rendu aujourd'hui par {this.Firstname} {this.Lastname}.");
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine($"\nVoici la liste des livres empeinté par {this.Firstname} {this.Lastname} : ");

            foreach (Book book in BorrowedBooks)
            {
                Console.WriteLine($"- {book.Title}, {book.Autor}, {book.Genre}, {book.NumberOfPages} pages.");
            }
        }
    }
}
