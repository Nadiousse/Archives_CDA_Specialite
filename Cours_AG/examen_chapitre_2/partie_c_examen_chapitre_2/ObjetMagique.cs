using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace partie_c_examen_chapitre_2
{
    public class ObjetMagique
    {
        public string Nom { get; set; }
        public double Valeur { get; set; }
        public int BonusPV { get; set; }
        public int BonusPM { get; set; }
        public int BonusAttaque { get; set; }
        public int BonusVitesse { get; set; }

        public ObjetMagique()
        {
            Nom = "Un Objet";
            Valeur = 10000;

            BonusPV = 0;
            BonusPM = 0;
            BonusAttaque = 0;
            BonusVitesse = 0;
        }

        public ObjetMagique(string initNom, double initValeur, int initBonusPV, int initBonusPM, int initBonusAttaque, int initBonusVitesse)
        {
            Nom = initNom;
            Valeur = initValeur;

            BonusPV = initBonusPV;
            BonusPM = initBonusPM;
            BonusAttaque = initBonusAttaque;
            BonusVitesse = initBonusVitesse;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}