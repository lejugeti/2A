using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtdLibrary
{
    public class Task
    {
        private int _repetition;
        public string Nom { get; set; }
        public virtual DateTime Today 
        {
            get
            {
                return DateTime.Today;
            }
        }
        public DateTime Echeance
        {
            get; set;
        }
        public bool Done { get; set; }
        public int Repetition
        {
            get { return _repetition; }
            set
            {
                if (value < 0) _repetition = 0;
                else _repetition = value;
            }
        }

        public int JoursAvantEcheance()
        {
            return (Echeance - Today).Days;
        }

        public void TacheTerminee()
        {
            if (Repetition != 0)
            {
                if(Echeance == null || Echeance == new DateTime(0))
                {
                    Done = true;
                }
                else
                {
                    Echeance = Echeance.AddDays(Repetition);
                    Done = false;
                }
                
            }
            else Done = true;
        }

        

        public static void Main()
        {
            Task t1 = new Task();
            Task t2 = new Task();
            Task t3 = new Task();

            t1.Echeance = new DateTime(2020, 10, 10);
            t2.Echeance = new DateTime(2020, 10, 11);
            t3.Echeance = new DateTime(2020, 10, 12);

            ToDoList l = new ToDoList();
            l.AjoutTask(t1);
            l.AjoutTask(t3);
            l.AjoutTask(t2);
            l.TrieParDate();

            ToDoList temp = new ToDoList();
            temp.AjoutTask(t1);
            temp.AjoutTask(t2);
            temp.AjoutTask(t3);


            Console.ReadKey();
        }
    }

    public class TaskDateTruquee : Task
    {
        public override DateTime Today
        {
            get
            {
                return new DateTime(2020, 10, 10);
            }
        }
    }
}
