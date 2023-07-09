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
    public class Part_Cat
    {
        [TestMethod]
        public void Test_o1()
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
        public void Test_o2x1a1()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n-10\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a2()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n0\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a3b1()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n1\n-20\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a3b2()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n1\n0\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a3b3()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n1\n1\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a3b4()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n1\n500\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a3b5()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n1\n1000\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a3b6()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n1\n1001\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a3b7()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n1\n3000\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a4b1()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n-20\n-20\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a4b2()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n0\n0\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a4b3()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n1\n1\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a4b4()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n500\n500\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a4b5()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n1000\n1000\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a4b6()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n1001\n1001\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a4b7()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n2\n3000\n3000\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a5b1()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n30\n-20\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a5b2()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n30\n0\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a5b3()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n30\n1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a5b4()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n30\n500\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a5b5()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n30\n1000\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a5b6()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n30\n1001\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a5b7()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n30\n3000\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12\n13\n14\n15\n16\n17\n18\n19\n20\n21\n22\n23\n24\n25\n26\n27\n28\n29\n30\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a6()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n31\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x1a7()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n1\nSerie_test1\n50\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o2x2()
        {
            var nrCartiInitial = Program.carti.Count;
            var inputConsola = new StringReader("nume_carte\nAutor_test1\nEditura_test1\nTip_test1\nGen_test1,Gen_test2\n0\n");
            Console.SetIn(inputConsola);

            Program.AdaugaCarte();

            Assert.AreEqual(nrCartiInitial + 1, Program.carti.Count);
        }

        [TestMethod]
        public void Test_o3()
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