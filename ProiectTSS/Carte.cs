using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProiectTSS
{
    public class Carte
    {
        public string Nume { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        public string Tip { get; set; }
        public List<string> Gen { get; set; }
        public SerieCarte Serie { get; set; }

        public Carte(string nume, string autor, string editura, string tip, List<string> gen, SerieCarte serie)
        {
            Nume = nume;
            Autor = autor;
            Editura = editura;
            Tip = tip;
            Gen = gen;
            Serie = serie;
        }

        public override string? ToString()
        {
            string print = $"{Nume}\n\tAutor: {Autor}\n\tEditura: {Editura}\n\tTip: {Tip}\n\tGen: {string.Join(", ", Gen)}\n";
            if (Serie != null)
            {
                print += $"Serie: {Serie.Nume}, Numar volume: {Serie.NrVolume}\n";
                for (int i = 0; i < Serie.NrVolume; i++)
                {
                    print += $"\tVolum {i + 1} - Pagini: {Serie.NrPgVolume[i]}\n";
                }
                print += $"\t\tNumar total de pagini: {Serie.NrTotalPagini()} \t Medie Pagini pe volum: {Serie.MediePagini()}";
            }
            return print;
        }
    }

    public class SerieCarte
    {
        public string Nume { get; }
        public int NrVolume { get; set; }
        public List<int> NrPgVolume { get; set; }

        public SerieCarte(string nume, int nrVolume, List<int> nrPgVolume)
        {
            Nume = nume;
            NrVolume = nrVolume;
            NrPgVolume = nrPgVolume;
        }

        public int NrTotalPagini()
        {
            int nrTotalPagini = 0;
            foreach (int pagini in NrPgVolume)
            {
                nrTotalPagini += pagini;
            }
            return nrTotalPagini;
        }

        public double MediePagini()
        {
            int nrTotalPagini = NrTotalPagini();
            int vomule = NrVolume;
            double mediePagini = 0;

            if (vomule > 0)
            {
                int i = 0;
                while (i < vomule)
                {
                    mediePagini += NrPgVolume[i];
                    i++;
                }
                mediePagini /= vomule;
            }

            return mediePagini;
        }
    }
}
