using System;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace ProiectTSS
{
    public class Program
    {
        public static List<Carte> carti = new List<Carte>();

        public static void Main(string[] args)
        {
            carti.Add(new Carte("Nume1", "Autor1", "Editura1", "Tip1", new List<string> { "Gen1", "Gen2" }, null));
            carti.Add(new Carte("Nume2", "Autor2", "Editura2", "Tip2", new List<string> { "Gen3", "Gen4" }, null));
            carti.Add(new Carte("Nume3", "Autor3", "Editura3", "Tip3", new List<string> { "Gen5", "Gen6" }, null));
            SerieCarte serie1 = new SerieCarte("Serie1", 2, new List<int> { 500, 550 });
            carti.Add(new Carte("Nume4", "Autor4", "Editura4", "Tip4", new List<string> { "Gen7", "Gen8" }, serie1));

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1 - Lista carti | 2 - Adauga carte | 3 - Sterge Carte | 0 - Inchide:");
                string comanda = Console.ReadLine().ToLower();

                switch (comanda)
                {
                    case "1":
                        ListaCarti();
                        break;
                    case "2":
                        AdaugaCarte();
                        break;
                    case "3":
                        StergeCarte();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Comanda incorecta");
                        break;
                }
            }
        }

        public static void AdaugaCarte()
        {
            Console.WriteLine("Nume:");
            string nume = Console.ReadLine();

            Console.WriteLine("Autor:");
            string autor = Console.ReadLine();

            Console.WriteLine("Editura");
            string editura = Console.ReadLine();

            Console.WriteLine("Tip:");
            string tip = Console.ReadLine();

            Console.WriteLine("Gen1,Gen2...:");
            string gen = Console.ReadLine();
            List<string> genrui = new List<string>(gen.Split(','));

            Console.Write("Apartine carte unei serii? (1/0)\n");
            string apartineserie = Console.ReadLine().ToLower();

            if (apartineserie == "1")
            {
                Console.Write("Nume Serie:");
                string numeSerie = Console.ReadLine();
                Console.Write("Numar de carti:");
                int nrVolume = int.Parse(Console.ReadLine());
                if (nrVolume > 0 && nrVolume < 31) 
                {
                    List<int> nrPgVolume = new List<int>();
                    bool nrpgnegative = false;
                    for (int i = 0; i < nrVolume; i++)
                    {
                        Console.Write($"Numar pagini pentru volumul {i + 1}: ");
                        int nr = int.Parse(Console.ReadLine());
                        if (nr > 0 && nr < 1001)
                        {
                            nrPgVolume.Add(nr);
                        }
                        else
                        {
                            Console.WriteLine("Numar de pagini este negativ sau prea mare (<1001)");
                            nrpgnegative = true;
                        }
                    }
                    if (nrpgnegative == false)
                    {
                        SerieCarte serie = new SerieCarte(numeSerie, nrVolume, nrPgVolume);
                        Carte carte = new Carte(nume, autor, editura, tip, genrui, serie);
                        carti.Add(carte);
                        Console.WriteLine("Carte adaugata.");
                    }
                }
                else
                {
                    Console.WriteLine("Numar de volume este negativ sau prea mare (<31)");
                }
                
            }
            else if (apartineserie == "0")
            {
                Carte carte = new Carte(nume, autor, editura, tip, genrui, null);
                carti.Add(carte);
                Console.WriteLine("Carte adaugata.");
            }
            else
            {
                Console.WriteLine("Carte nu a fost adaugata. Raspuns asteptat: 0 sau 1");
            }

        }

        public static void ListaCarti()
        {
            if (carti.Count == 0)
            {
                Console.WriteLine("Numarul de carti este 0");
            }
            else
            {
                foreach (Carte carte in carti)
                {
                    Console.WriteLine(carte);
                }
            }
        }

        public static void StergeCarte()
        {
            Console.WriteLine("Nume:");
            string nume = Console.ReadLine();

            bool deleted = false;
            for (int i = 0; i < carti.Count; i++)
            {
                if (carti[i].Nume.ToLower() == nume.ToLower())
                {
                    carti.RemoveAt(i);
                    Console.WriteLine("Carte a fost stearsa.");
                    deleted = true;
                    break;
                }
            }
            if (!deleted)
            {
                Console.WriteLine("Cartea nu a fost gasita.");
            }
        }
    }
}