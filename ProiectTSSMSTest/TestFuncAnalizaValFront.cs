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
    public class AnalizaValFront
    {
        [TestMethod]
        public void TestC2111_1()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n1\n100\n");
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
            Assert.AreEqual(1, carteAdaugata.Serie.NrVolume);
            CollectionAssert.AreEqual(new List<int> { 100 }, carteAdaugata.Serie.NrPgVolume);
        }

        [TestMethod]
        public void TestC2111_2()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n30\n2\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n");
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
            Assert.AreEqual(30, carteAdaugata.Serie.NrVolume);
            CollectionAssert.AreEqual(new List<int> { 2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 }, carteAdaugata.Serie.NrPgVolume);
        }

        [TestMethod]
        public void TestC2111_3()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n1\n1\n");
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
            CollectionAssert.AreEqual(new List<int> { 1, 1 }, carteAdaugata.Serie.NrPgVolume);
        }

        [TestMethod]
        public void TestC2111_4()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n1000\n1000\n");
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
            CollectionAssert.AreEqual(new List<int> { 1000, 1000 }, carteAdaugata.Serie.NrPgVolume);
        }

        [TestMethod]
        public void TestC2112()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n100\n0\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void TestC2113()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n100\n1001\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void TestC212()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n0\n100\n1500\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void TestC213()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n31\n100\n1500\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }
    }
}