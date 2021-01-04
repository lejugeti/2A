using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Dessin
    {
        public Rectangle[] Tab { get; set; }

        public Dessin()
        {
            Tab = new Rectangle[0];
        }

        public void AjoutRectangle()
        {
            Console.Write("Entrez l'abscisse du PointGauche : ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Entrez l'ordonnée du PointGauche : ");
            int y1 = Int32.Parse(Console.ReadLine());
            Console.Write("Entrez la largeur du Rectangle : ");
            int largeur = Int32.Parse(Console.ReadLine());
            Console.Write("Entrez la hauteur du Rectangle : ");
            int hauteur = Int32.Parse(Console.ReadLine());

            Rectangle tempRect = new Rectangle(x1, y1, largeur, hauteur);
            Rectangle[] tempTab = new Rectangle[Tab.Length+1];

            for(int i=0; i< Tab.Length; i++)
            {
                tempTab[i] = Tab[i];
            }

            tempTab[tempTab.Length - 1] = tempRect;
            Tab = tempTab;
        }

        public void Affiche()
        {
            foreach(Rectangle rect in Tab)
            {
                rect.affiche();
            }
        }

        public int CalculeSurface()
        {
            int surfaceTotale = 0;

            foreach(Rectangle rect in Tab)
            {
                surfaceTotale += rect.CalculeSurface();
            }

            return surfaceTotale;
        }

        public void SetPosition(int x, int y)
        {
            foreach(Rectangle rect in Tab)
            {
                rect.SetPosition(x, y);
            }
        }
    }
}
