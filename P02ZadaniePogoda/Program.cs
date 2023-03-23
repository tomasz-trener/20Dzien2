using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace P02ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szukanyZnak = "°";
            string znakKoncowy = ">";

            while (true)
            {
                Console.WriteLine("Podaj nazwe miasta");
                string miasto = Console.ReadLine();
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
                        if (liczbaIteracji>4)
                            throw new Exception();      
                    }

                    //int i;
                    //for (i = indx; dane.Substring(i, 1) != znakKoncowy; i--)
                    //{

                    //}


                    string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);
                    Console.WriteLine(wynik);
                }
                catch (Exception)
                {
                    Console.WriteLine("Nie udało się pobrać temperatury");
                    continue;
                }              
            }
            

            Console.ReadKey();

        }
    }
}
