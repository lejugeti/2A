using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Carte
    {
        protected string Numero { get; set; }
        protected string Symbole { get; set; }

        public Carte(string numero)
        {
            Numero = numero;
            Symbole = "Inconnue";
        }
        public Carte(string numero, string symbole)
        {
            Numero = numero;
            Symbole = symbole;
        }

        public void affiche()
        {
            Console.WriteLine($"Carte :{Numero} Couleur :{Symbole}");
        }

        public void setCouleur(string couleur)
        {
            Symbole = couleur;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carte maCarte = new Carte("As", "Trèfle");
            maCarte.affiche();

            Carte maCarte2 = new Carte("Roi");
            maCarte2.affiche();
            maCarte2.setCouleur("Carreau");
            maCarte2.affiche();
            Console.ReadKey();
        }
    }
}
