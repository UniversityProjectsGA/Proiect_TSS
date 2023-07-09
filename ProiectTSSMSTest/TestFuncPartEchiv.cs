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
    public class Part_Echiv
    {
        [TestMethod]
        public void Test_C1()
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
        public void TestC2111()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n100\n150\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
            var carteAdaugata = Program.carti.Last();
            Assert.AreEqual("nume_carte", carteAdaugata.Nume);
            Assert.AreEqual("Autor_test1", carteAdaugata.Autor);
            Assert.AreEqual("Editura_test1", carteAdaugata.Editura);
            Assert.AreEqual("Tip_test1", carteAdaugata.Tip);
            CollectionAssert.AreEqual(new List<string> { "Gen_test1", "Gen_test2" }, carteAdaugata.Gen);
            Assert.IsNotNull(carteAdaugata.Serie);
            Assert.AreEqual("Serie_test1", carteAdaugata.Serie.Nume);
            Assert.AreEqual(2, carteAdaugata.Serie.NrVolume);
            CollectionAssert.AreEqual(new List<int> { 100, 150 }, carteAdaugata.Serie.NrPgVolume);
        }

        [TestMethod]
        public void TestC2112()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n100\n-150\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void TestC2113()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n100\n1500\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void TestC212()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n-2\n100\n1500\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void TestC213()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n200\n100\n1500\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void TestC22()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n0\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
            var carteAdaugata = Program.carti.Last();
            Assert.AreEqual("nume_carte", carteAdaugata.Nume);
            Assert.AreEqual("Autor_test1", carteAdaugata.Autor);
            Assert.AreEqual("Editura_test1", carteAdaugata.Editura);
            Assert.AreEqual("Tip_test1", carteAdaugata.Tip);
            CollectionAssert.AreEqual(new List<string> { "Gen_test1", "Gen_test2" }, carteAdaugata.Gen);
            Assert.IsNull(carteAdaugata.Serie);
        }

        [TestMethod]
        public void TestC3()
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
    }
}