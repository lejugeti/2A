using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Panne
    {
        private string _libelle;
        private Periode _periodePrevue;
        private Periode _periodeReelle;

        public Panne(string libelle, Periode periodePrevue, Periode periodeReelle)
        {
            _libelle = libelle;
            _periodePrevue = periodePrevue;
            _periodeReelle = periodeReelle;
        }

        public void ecarts(out int nbJours, out double montant)
        {
            int jourPrevue = _periodePrevue.DateFin.Subtract(_periodePrevue.DateDebut).Days;
            int jourReelle = _periodeReelle.DateFin.Subtract(_periodeReelle.DateDebut).Days;

            nbJours = jourReelle - jourPrevue;

            montant = 0;
            if(nbJours >=2 && nbJours <= 4)
            {
                montant = 15;
            }
            else if(nbJours>=5 && nbJours <= 10)
            {
                montant = 15;
                int rab = nbJours - 4;
                montant += rab * 20;
            }
            else if (nbJours >= 11)
            {
                montant = 15;
                montant += 6 * 20;
                int rab = nbJours - 10;
                montant += rab * 10;
                
            }
        }
    }
}
