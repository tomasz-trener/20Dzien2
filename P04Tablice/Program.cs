using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miasto1 = "kraków";
            string miasto2 = "warszawa";
            string miasto3 = "gdańsk";
            //...

            string[] miasta = new string[4];

            miasta[0] = miasto1;
            miasta[1] = miasto2;
            //...
            miasta[3] = "wrocław";

            int dlugoscTablicy = miasta.Length; // 4

            Console.WriteLine(miasta[0]);
            Console.WriteLine(miasta[2]);

            int?[] liczby1 = new int?[2];

           // Console.WriteLine(liczby1[0]);
            int[] liczby2 = new int[3] { 4, 7, 1 };

            int[] liczby3 = { 5, 2, 7, 3 }; //zrobienie tablicy 4-elementowej


            bool[] tablicaWartosciLogicznych = { true, true, false };
            char[] znaki = { 'a', 'b' };




            Console.ReadKey();
        }
    }
}
