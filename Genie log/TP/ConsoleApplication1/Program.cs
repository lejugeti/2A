using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Voiture v = new Voiture(4, "1234");
        double cout = v.Rouler(100, 800);
        Console.WriteLine(cout);
        Console.ReadKey();
    }
}
