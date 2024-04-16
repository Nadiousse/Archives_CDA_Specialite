using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace partie_b_examen_chapitre_2
{
    public class Client
    {

        public string Nom { get; set; }
        public string Prénom { get; set; }
        public decimal Fonds { get; set; }

        public Client(string nom, string prénom, decimal fonds)
        {
            Nom = nom;
            Prénom = prénom;
            Fonds = fonds;
        }
    }
}