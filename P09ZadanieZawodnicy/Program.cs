using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj kraj");
            string kraj = Console.ReadLine().ToLower();

            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            // zabezpieczenie dla innych
            // programistow przed proba nadpisania tej wartosci 

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(sciezka);

            string[] wiersze=
                dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> zawodnicy = new List<string>();
            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki= wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                    zawodnicy.Add(komorki[2] + " " + komorki[3]);
            }

            const string sciezkaWynik = @"c:\dane\kraje";
            if (!Directory.Exists(sciezkaWynik))
                Directory.CreateDirectory(sciezkaWynik);

            File.WriteAllLines(sciezkaWynik + $"\\{kraj}.txt", zawodnicy);

        }
    }
}
