using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    interface IZoomable
    {
        void zoom(double coef);
        double volume();
        double aire();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cube c = new Cube(2);
            Console.WriteLine(c.Cote);
            Console.WriteLine(c.volume());
            Console.WriteLine(c.aire());
            Console.ReadKey();
        }
    }
}
