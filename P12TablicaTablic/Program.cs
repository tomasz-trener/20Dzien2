using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12TablicaTablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablicaJednoWymiarowa = new string[3];

            string[,] tablicaDwuWymiarowa = new string[3, 2];

            string[][] tablicaTablic = new string[4][];

            tablicaTablic[0] = new string[2];
            tablicaTablic[1] = new string[3] { "x", "y", "z" };
            tablicaTablic[2] = new string[] { "u","k" };

            tablicaTablic[0][0] = "A";
            tablicaTablic[0][1] = "B";

            int dlugosc = tablicaTablic.Length; //4

            int dlugoscKonkretnejTablicyWewnetrznej = tablicaTablic[1].Length; // 3


        }
    }
}
