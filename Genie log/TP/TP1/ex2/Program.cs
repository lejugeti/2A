using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Rectangle
    {
        

        public Point PointGauche { get; set; }
        protected int DimHoriz { get; set; }
        protected int DimVert { get; set; }
        
        //Constructeurs
        public Rectangle(Point p1, Point p2)
        {
            if(p1.X < p2.X && p1.Y < p2.Y)
            {
                PointGauche = p1;
            }
            else
            {
                PointGauche = p2;
            }

            DimHoriz = p2.X - p1.X;
            DimVert = p2.Y - p1.Y;
        }
        public Rectangle(Point p1, int largeur, int hauteur)
        {
            PointGauche = p1;
            DimHoriz = largeur;
            DimVert = hauteur;
         
        }
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            PointGauche = new Point(x1, y1);
            DimHoriz = x2 ;
            DimVert = y2;
        }

        //Méthodes
        public void affiche()
        {
            Console.Write($"PointGauche = ");
            PointGauche.affiche();
            Console.WriteLine($"DimHoriz = {DimHoriz}");
            Console.WriteLine($"DimVert = {DimVert}");
            Console.WriteLine("");

        }

        public int CalculeSurface()
        {
            int surface = DimVert * DimHoriz;
            return surface;
        }

        /*Déplace le rectangle en déplaçant le point en bas à gauche de x et y*/
        public void SetPosition(int x, int y)
        {
            PointGauche.X += x;
            PointGauche.Y += y;
        }

        public bool EstEgal(Rectangle rect2)
        {
            if (DimHoriz == rect2.DimHoriz && DimVert == rect2.DimVert)
            {
                return true;
            }
            else return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(2, 2);
            Rectangle rect = new Rectangle(1,1,2,2);
            rect.SetPosition(1, 1);
            rect.affiche();
            Console.WriteLine($"Surface = {rect.CalculeSurface()}");
            Console.WriteLine(rect.EstEgal(rect));

            Dessin d = new Dessin();
            d.AjoutRectangle();
            d.AjoutRectangle();
            d.Affiche();
            Console.WriteLine(d.CalculeSurface());

            d.SetPosition(2, 2);
            d.Affiche();
            Console.ReadKey();
        }
    }
}
