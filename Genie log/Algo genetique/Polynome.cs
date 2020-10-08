using System;

public class Polynome
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double Delta { get; set; }
    public List<double> Solutions { get; set; }
    public Polynome(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;

        Solutions = new List<double>();
    }

    public double CalculDelta()
	{
        Delta = B * B - 4 * A * C;

	}
}
