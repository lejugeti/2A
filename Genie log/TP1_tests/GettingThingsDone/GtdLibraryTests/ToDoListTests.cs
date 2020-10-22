using Microsoft.VisualStudio.TestTools.UnitTesting;
using GtdLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtdLibrary.Tests
{
    [TestClass()]
    public class ToDoListTests
    {
        [TestMethod()]
        public void AjoutTaskTest()
        {
            ToDoList l = new ToDoList();
            Task t = new Task();
            l.AjoutTask(t);

            Assert.IsTrue(l.Liste.Count == 1);
        }

        [TestMethod()]
        public void SupprTaskTest()
        {
            ToDoList l = new ToDoList();
            l.Liste.Add(new Task());
            l.SupprTask(0);

            Assert.IsTrue(l.Liste.Count == 0);
        }

        [TestMethod()]
        public void TriParTitreTest()
        {
            Task t1 = new Task();
            Task t2 = new Task();
            Task t3 = new Task();

            t1.Nom = "b";
            t2.Nom = "a";
            t3.Nom = "c";

            ToDoList l = new ToDoList();
            l.AjoutTask(t2);
            l.AjoutTask(t3);
            l.AjoutTask(t1);

            l.TriParTitre();
            List<Task> temp = new List<Task>();
            temp.Add(t2);
            temp.Add(t1);
            temp.Add(t3);

            CollectionAssert.AreEquivalent(l.Liste, temp);
        }

        [TestMethod()]
        public void TrieParDateTest()
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

            CollectionAssert.AreEquivalent(l.Liste, temp.Liste);
        }
    }
}