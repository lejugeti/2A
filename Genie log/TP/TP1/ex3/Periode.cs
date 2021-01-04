using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Periode
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;

        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }
        public DateTime DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }
        public Periode(DateTime debut, DateTime fin)
        {
            _dateDebut = debut;
            _dateFin = fin;
        }
    }
}
