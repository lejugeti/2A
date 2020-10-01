using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtdLibrary
{
    class Task
    {
        private int _repetition;
        protected string Nom { get; set; }
        protected virtual DateTime Today 
        {
            get
            {
                return DateTime.Today;
            }
        }
        protected DateTime Echeance
        {
            get; set;
        }
        protected bool Done { get; set; }
        protected int Repetition
        {
            get { return _repetition; }
            set
            {
                if (value < 0) _repetition = 0;
                else _repetition = value;
            }
        }

        protected int JoursAvantEcheance()
        {
            return (Echeance - Today).Days;
        }

        public void TacheTerminee()
        {
            if (Repetition != 0)
            {
                Echeance.AddDays(Repetition);
            }
            else Done = true;
        }
    }
}
