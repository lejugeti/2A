using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtdLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = new DateTime(2020, 2, 10);
            DateTime b = new DateTime(2020, 2, 20);
            Console.WriteLine(a.AddDays(2));
            Console.ReadKey();
        }
    }
}
