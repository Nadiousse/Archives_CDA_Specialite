using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace partie_c_examen_chapitre_2
{
    public class Joueur
    {
        private ObjetMagique[] Inventaire;
        public double PO { get; set; }
        public double PV { get; set; }
        public double PM { get; set; }
        public double Attaque { get; set; }
        public double Vitesse { get; set; }

        public Joueur()
        {
            PO = 0;
            Inventaire = new ObjetMagique[6];

            PV = 10000;
            PM = 6000;
            Attaque = 100;
            Vitesse = 250;
        }

        public void AcheterObjet(ObjetMagique objetMagique, int emplacementInventaire)
        {
            if (Inventaire[emplacementInventaire] == null && PO >= objetMagique.Valeur)
            {
                PO -= objetMagique.Valeur;
                Inventaire[emplacementInventaire] = objetMagique;

                PV += objetMagique.BonusPV;
                PM += objetMagique.BonusPM;
                Attaque += objetMagique.BonusAttaque;
                Vitesse += objetMagique.BonusVitesse;
            }
            else
            {
                Console.WriteLine("Je ne peux pas acheter cet objet.");
            }
        }

        public void AfficherInventaire()
        {
            for (int i = 0; i < Inventaire.Length; i++)
            {
                if (Inventaire[i] != null)
                {
                    Console.WriteLine($"{i}. {Inventaire[i]}");
                }
                else
                {
                    Console.WriteLine($"{i}. vide");
                }
            }
        }
    }
}