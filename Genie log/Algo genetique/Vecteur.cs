using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Algo_genetique
{
    public class Vecteur
    {
        const double g = 1.6;
        public const double atterritpas = 10000000.0;

        private double _d;
        private double _k;
        private double _note;

        public double _vx;
        public double _vy;

        public Vecteur(double newd, double newk)
        {
            _d = newd;  // en degrés
            _k = newk;
        }
        public double Getd() { return _d; }
        public void SetDir(double d) { _d = d; }
        public double Getk() { return _k; }
        public void Setk(double k) { _k = k; }
        public double GetNote() { return _note; }

        public void CalculeNote(double x0, double y0, double vx0, double vy0)
        {
            double d2 = _d / 180.0 * Math.PI;
            double ax = _k * g * Math.Cos(d2);
            double ay = g * (_k * Math.Sin(d2) - 1);
            // Calcul de t pour y=0; y(t) = ½ ay t2 + vy0 t + y0 => équation 2nd degré à résoudre
            double delta = vy0 * vy0 - 4 * 0.5 * ay * y0;
            if (delta <= 0)
            {
                // N'atterrit jamais => note la plus forte (donc la plus mauvaise)
                _vx = 1000000;
                _vy = 1000000;
                _note = atterritpas;
            }
            else
            {
                // Si ralentissement de la chute (ay > 0), la solution est en t le plus faible (premier passage par y=0)
                // si au contraire la chute est de plus en plus rapide avec ay < 0, la solution de l'équation est en t négatif
                // ce qui bien sûr est impossible, donc on prend le t le plus grand.
                double t1 = (-vy0 - Math.Sqrt(delta)) / (2 * 0.5 * ay);
                double t2 = (-vy0 + Math.Sqrt(delta)) / (2 * 0.5 * ay);
                double t;
                if (ay < 0) { t = Math.Max(t1, t2); }
                else { t = Math.Min(t1, t2); }
                // On reporte t dans vx et vy pour avoir la vitesse à l'atterrissage
                _vx = ax * t + vx0;
                _vy = ay * t + vy0;
                _note = _vx * _vx + _vy * _vy;
            }
        }

        public Vecteur(Vecteur v)
        {
            _d = v._d;
            _k = v._k;
            
        }

    }
}
