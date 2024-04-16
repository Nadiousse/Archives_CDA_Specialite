using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_7_bibliotheque
{
    internal class Book
    {
        public Genre Genre { get; set; }

        public string Title { get; set; }
        public string Autor { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string initTitle, string initAutor, Genre initGenre, int initNumberOfPages)
        {
            Title = initTitle;
            Autor = initAutor;
            Genre = initGenre;
            NumberOfPages = initNumberOfPages;
        }
    }
}
