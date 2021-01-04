using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Emprunt
    {
        public virtual int Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Utilisateur Emprunteur { get; set; }
        public virtual Livre Livre { get; set; }
        public virtual bool Rendu { get; set; }

        public Emprunt()
        {

        }

        public Emprunt(DateTime date, Utilisateur emprunteur, Livre livre, bool rendu)
        {
            Date = date;
            Emprunteur = emprunteur;
            Livre = livre;
            Rendu = rendu;
        }
    }
}
