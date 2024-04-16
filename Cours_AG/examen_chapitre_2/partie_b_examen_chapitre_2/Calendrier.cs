using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace partie_b_examen_chapitre_2
{
    public class Calendrier
    {
        public event Action PremierDuMois;

        public void DeclancherPremierDuMois()
        {
            if (PremierDuMois != null)
            {
                PremierDuMois();
            }
        }
    }
}