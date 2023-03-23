using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieListy
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
                Console.WriteLine($"[{i + 1}] {miastaZPliku[i]}");

            List<int> listaTemperatur = new List<int>();
            List<string> listaMiasta = new List<string>();
            while (true)
            {
                Console.WriteLine("Wybierz miasto (podaj numer)");
                string miastoString = Console.ReadLine();
                int nrMiasta = Convert.ToInt32(miastoString);
                string miasto = miastaZPliku[nrMiasta - 1];
                listaMiasta.Add(miasto);
                
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


                    string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);
                    Console.WriteLine($"Temperatura dla miasta {miasto}: {wynik}");

                    //12 
                    listaTemperatur.Add(Convert.ToInt32(wynik.Substring(0, wynik.Length - 2)));
                    //teraz liczby średnią temperature
                    double sredniaTemp = 0;
                    foreach (var t in listaTemperatur)
                        sredniaTemp += t;

                    //sredniaTemp = sredniaTemp / listaTemperatur.Count;
                    sredniaTemp /= listaTemperatur.Count;

                    string raport = string.Format("średnia temperatura w miasta {0} wynosi {1}",
                        string.Join(", ", listaMiasta),sredniaTemp);
                    Console.WriteLine(raport);

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
