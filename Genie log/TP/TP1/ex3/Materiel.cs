using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Materiel
    {
        public string Libelle { get; set; }
        public Panne[] LesPannes { get; set; } = new Panne[0];
        public int nbPannes { get; set; }

        public void AjoutPanne(Panne p)
        {
            Panne[] tempPannes = new Panne[LesPannes.Length + 1];

            for(int i =0; i < LesPannes.Length; i++)
            {
                tempPannes[i] = LesPannes[i];
            }

            tempPannes[tempPannes.Length - 1] = p;
            LesPannes = tempPannes;
        }

        public int CumulPannes()
        {
            int totalMontant = 0;
            foreach(Panne p in LesPannes)
            {
                int nbJours;
                double montant;
                p.ecarts(out nbJours, out montant);
                totalMontant += (int) montant;

            }

            return totalMontant;
        }
    }
}
