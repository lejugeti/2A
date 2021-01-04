using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = new DateTime(2003, 04, 23);
            DateTime b = new DateTime(2004, 04, 26);
            Periode prevue = new Periode(new DateTime(2003, 04, 23), new DateTime(2003, 05, 15));
            Periode reelle = new Periode(new DateTime(2003, 04, 23), new DateTime(2003, 05, 27));
            Panne p = new Panne("Blocage du compteur", prevue, reelle);

            int nbJours;
            double montant;
            p.ecarts(out nbJours, out montant);
            Console.WriteLine(montant);
            Console.ReadKey();
        }
    }
}
