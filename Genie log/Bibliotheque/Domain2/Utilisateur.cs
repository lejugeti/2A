using System;

namespace Domain
{
    public class Utilisateur
    {
        /*private int id;
        private string nom;
        private string prenom;*/

        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }

        public Utilisateur(int id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }

        public string Decrire()
        {
            return $"{Id} : {Nom} {Prenom}";
        }
    }
}
