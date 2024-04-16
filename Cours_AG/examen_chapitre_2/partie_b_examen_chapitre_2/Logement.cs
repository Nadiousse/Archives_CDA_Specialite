using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace partie_b_examen_chapitre_2
{
    public class Logement
    {
        public Client Proprietaire { get; set; }
        public Client Locataire { get; set; }
        public decimal TarifLogement { get; set; }
        public string NomDuLogement { get; set; }

        public Logement(Client proprietaire, Client locataire, decimal tarifLogement, string nomDuLogement, Calendrier calendrier)
        {
            Proprietaire = proprietaire;
            Locataire = locataire;
            TarifLogement = tarifLogement;
            NomDuLogement = nomDuLogement;

            calendrier.PremierDuMois += PayerLoyer;
        }

        public void PayerLoyer()
        {
            Locataire.Fonds -= TarifLogement;
            Proprietaire.Fonds += TarifLogement;
            Console.WriteLine("Loyer payé pour le logement " + NomDuLogement + ".");
        }

    }
}