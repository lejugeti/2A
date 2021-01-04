using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Voiture v = new Voiture(4, "1234");
        Console.WriteLine(v.Rouler(100, 100));
        Console.ReadKey();
    }
}
