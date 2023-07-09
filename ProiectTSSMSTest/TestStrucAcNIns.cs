using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProiectTSS;

namespace ProiectTSSMSTest
{
    [TestClass]
    public class AcopNivIns
    {
        [TestMethod]
        public void Test_ANI1()
        {
            StringWriter printConsola = new StringWriter();
            Console.SetOut(printConsola);

            Program.carti.Clear();
            Program.carti.Add(new Carte("nume_carte", "Autor_test1", "Editura_test1", "Tip_test1", new List<string> { "Gen_test1" }, null));

            Program.ListaCarti();

            string printAsteptat = "nume_carte\n\tAutor: Autor_test1\n\tEditura: Editura_test1\n\tTip: Tip_test1\n\tGen: Gen_test1";
            Assert.AreEqual(printAsteptat, printConsola.ToString().Trim());
        }

        [TestMethod]
        public void Test_ANI2()
        {
            StringWriter printConsola = new StringWriter();
            Console.SetOut(printConsola);

            Program.carti.Clear();

            Program.ListaCarti();

            string printAsteptat = "Numarul de carti este 0";
            Assert.AreEqual(printAsteptat, printConsola.ToString().Trim());
        }

        [TestMethod]
        public void Test_ANI3()
        {
            Program.carti.Clear();
            Program.carti.Add(new Carte("nume_carte", "Autor_test1", "Editura_test1", "Tip_test1", new List<string> { "Gen_test1", "Gen_test2" }, null));
            Program.carti.Add(new Carte("Nume_test2", "Autor_test2", "Editura_test2", "Tip_test2", new List<string> { "Gen_test3", "Gen_test4" }, null));

            System.IO.StringReader sr = new System.IO.StringReader("nume_carte\n");
            Console.SetIn(sr);
            Program.StergeCarte();

            Assert.AreEqual(1, Program.carti.Count);
            Assert.AreEqual("Nume_test2", Program.carti[0].Nume);
        }

        [TestMethod]
        public void TestANI4()
        {

            Program.carti.Clear();
            Program.carti.Add(new Carte("Nume_test1", "Autor_test1", "Editura_test1", "Tip_test1", new List<string> { "Gen_test1", "Gen_test2" }, null));
            Program.carti.Add(new Carte("Nume_test2", "Autor_test2", "Editura_test2", "Tip_test2", new List<string> { "Gen_test3", "Gen_test4" }, null));

            System.IO.StringReader sr = new System.IO.StringReader("nume_carte\n");
            Console.SetIn(sr);
            Program.StergeCarte();

            Assert.AreEqual(2, Program.carti.Count);
        }
    }
}