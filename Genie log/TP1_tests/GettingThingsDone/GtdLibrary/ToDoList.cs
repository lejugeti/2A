using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtdLibrary
{
    public class ToDoList
    {
        public List<Task> Liste = new List<Task>();

        public void AjoutTask(Task t)
        {
            Liste.Add(t);
        }

        public void SupprTask(int index)
        {
            Liste.RemoveAt(index);
        }

        public void TriParTitre()
        {
            Liste.Sort(CompareTitre);
        }

        public void TrieParDate()
        {
            Liste.Sort(CompareDate);
        }

        private int CompareTitre(Task t1, Task t2)
        {
            int comparaison = t1.Nom.CompareTo(t2.Nom);

            return comparaison;
        }

        private int CompareDate(Task t1, Task t2)
        {
            int comparaison = t1.Echeance.CompareTo(t2.Echeance);

            return comparaison;
        }

    }
}
