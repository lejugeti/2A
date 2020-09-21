using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Point
    {
        
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int abs, int ord)
            {
                X = abs;
                Y = ord;
            }

            public void affiche()
            {
                Console.WriteLine($"({X},{Y})");
            }

            public void AjouteDistance(int x, int y)
            {
                X += x;
                Y += y;
            }
        
    }
}
