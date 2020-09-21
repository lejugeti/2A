using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Cube:IZoomable
    {
        public double Cote { get; set; }

        public Cube(double cote)
        {
            Cote = cote;
        }
        public void zoom(double z)
        {
            Cote = Cote * z;
        }

        public double volume()
        {
            return Cote * Cote * Cote;
        }
        public double aire()
        {
            return Cote * Cote * 6;
        }
    }
}
