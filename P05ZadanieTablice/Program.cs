﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szukanyZnak = "°";
            string znakKoncowy = ">";

            string[] miastaZPliku = File.ReadAllLines(@"C:\dane\miasta.txt");

            Console.WriteLine("Dostępne miasta:");
            for (int i = 0; i < miastaZPliku.Length; i++)
                Console.WriteLine($"[{i+1}] {miastaZPliku[i]}");

            while (true)
            {
                Console.WriteLine("Wybierz miasto (podaj numer)");
                string miastoString = Console.ReadLine();
                int nrMiasta = Convert.ToInt32(miastoString);
                string miasto = miastaZPliku[nrMiasta - 1];

                string adres = $"https://www.google.com/search?q=pogoda {miasto}";

                WebClient wc = new WebClient();
                string dane = wc.DownloadString(adres);

                try
                {
                    int indx = dane.IndexOf(szukanyZnak);
                    int aktualnaPozycja = indx;
                    int liczbaIteracji = 0;

                    while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                    {
                        liczbaIteracji++;
                        aktualnaPozycja--;
                        if (liczbaIteracji > 4)
                            throw new Exception();
                    }

                    //int i;
                    //for (i = indx; dane.Substring(i, 1) != znakKoncowy; i--)
                    //{

                    //}


                    string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);
                    Console.WriteLine($"Temperatura dla miasta {miasto}: {wynik}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Nie udało się pobrać temperatury");
                    continue;
                }
            }

        }
    }
}
