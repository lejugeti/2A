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
    public class TaskTests
    {
        [TestMethod()]
        public void JoursAvantEcheance()
        {
            TaskDateTruquee t = new TaskDateTruquee();
            DateTime today = t.Today;
            t.Echeance = new DateTime(2020, 10, 20);
            Assert.AreEqual(t.JoursAvantEcheance(), 10);
        }

        [TestMethod()]
        public void JoursAvantEcheanceNull()
        {
            Task t = new Task();
            DateTime today = t.Today;
            t.Echeance = new DateTime(0);
            DateTime temp = new DateTime(0);

            Assert.AreEqual(t.Echeance, temp);
        }

        [TestMethod()]
        public void TacheTermineeTest()
        {
            Task t = new Task();
            t.TacheTerminee();

            Assert.AreEqual(t.Done, true);
        }

        [TestMethod()]
        public void TacheTermineeCycleDateTest()
        {
            Task t = new Task();
            t.Echeance = new DateTime(2020, 10, 10);
            DateTime tempEcheance = new DateTime(2020, 10, 10);
            t.Repetition = 10;
            t.TacheTerminee();

            Assert.AreEqual(t.Done, false);
            Assert.AreEqual(t.Echeance, tempEcheance.AddDays(10));
        }

        [TestMethod()]
        public void TacheTermineeCycleSansDateTest()
        {
            Task t = new Task();
            t.Echeance = new DateTime(0);
            t.Repetition = 10;
            t.TacheTerminee();

            Assert.AreEqual(t.Done, true);
            Assert.AreEqual(t.Echeance, new DateTime(0));
        }
    }

    
    
}