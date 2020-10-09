using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_genetique
{
    class Population
    {
        private const int _nbIndividus = 1000;
        public List<Vecteur> Individus { get; set; }

        public Population()
        {
            Individus = new List<Vecteur>();
            for (int i = 0; i < _nbIndividus; i++)
            {
                Vecteur tempV = new Vecteur();
                tempV.CalculeNote(400,400, -10,10);
                Individus.Add(tempV);
            }
        }

        public Vecteur GetBestInd()
        {
            Vecteur bestInd = new Vecteur();
            double bestNote = 1000000;

            foreach(Vecteur v in Individus)
            {
                if(v.GetNote() < bestNote)
                {
                    bestNote = v.GetNote();
                    bestInd = v;
                }
            }

            return bestInd;
        }
        
        
    }
}
