using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_genetique
{
    class Runner
    {
        protected Population Pop{ get; set; }
        const double x0 = 400;
        const double y0 = 400;
        const double vx0 = -10;
        const double vy0 = -10;

        public Runner()
        {
            Pop = new Population();
        }

        public void CalculeNote()
        {
            foreach (Vecteur v in Pop.Individus)
            {
                v.CalculeNote(x0, y0, vx0, vy0);
            }
        }
        
        public int Compare(Vecteur v1, Vecteur v2)
        {
            if (v1.GetNote() < v2.GetNote()) return -1;
            else if (v2.GetNote() < v1.GetNote()) return 1;
            else return 0;
        }

        public void CreateNextGen()
        {
            Pop.Individus.Sort(Compare);
            Pop.Individus.RemoveRange(100, 900);

            int ancienIndex = 0;
            Vecteur tempV;
            for(int i = 0; i < 899; i++)
            {
                tempV = new Vecteur(Pop.Individus[i]);

                Random rng = new Random();
                //pour la direction
                bool positif;
                if (rng.NextDouble() < 0.5) { positif = true; }
                else positif = false;

                if (positif)
                {
                    tempV.SetDir(tempV.Getd() * 1.03);
                }
                else tempV.SetDir(tempV.Getd() * (-1) * 1.03);

                //pour la poussée
                if (rng.NextDouble() < 0.5) { positif = true; }
                else positif = false;

                if (positif)
                {
                    tempV.Setk(tempV.Getk() * 1.03);
                }
                else tempV.Setk(tempV.Getk() * (-1) * 1.03);

                Pop.Individus.Add(tempV);
                ancienIndex++;

                if (ancienIndex >= 100) ancienIndex = 0;

                //ajout de l'individu à la population
                tempV.CalculeNote(x0, y0, vx0, vy0);
                Pop.Individus.Add(tempV);
            }
        }

        public void PrintBest(int nbGen)
        {
            Console.WriteLine($"Generation {nbGen}");
            Console.WriteLine($"Meilleure vitesse = {Pop.GetBestInd().GetNote()} \n");
        }
        public void Run()
        {
            for(int gen=0; gen < 1000; gen++)
            {
                CreateNextGen();

                
            }

            Pop.Individus.Sort(Compare);
            Console.WriteLine(Pop.Individus[0].GetNote());
        }


    }
    class Program
    {

        static void Main(string[] args)
        {
            Runner a = new Runner();
            a.Run();
            Console.ReadKey();
            

            
        }
    }
}
