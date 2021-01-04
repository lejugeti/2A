using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Livre
    {
        public virtual string Auteur { get; set; }
        public virtual int Id { get; set; }
        public virtual string ISBN { get; set; }
        public virtual string Titre { get; set; }

        public Livre()
        {

        }

        public Livre(string auteur, int id, string isbn, string titre)
        {
            Auteur = auteur;
            Id = id; 
            ISBN = isbn;
            Titre = titre;
        }

        public virtual string Decrire()
        {
            return $"{Titre}";
        }
    }
}
