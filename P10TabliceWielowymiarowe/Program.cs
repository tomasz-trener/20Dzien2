using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10TabliceWielowymiarowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablicaJednoWym = new string[3];

            string[,] tablicaDwuWm = new string[4, 2];

            string[,,] tablicaTrzyWym = new string[4, 2, 2];

            tablicaTrzyWym[0, 0, 0] = "a";
            tablicaTrzyWym[0, 0, 1] = "b";

            int dlugosc = tablicaTrzyWym.Length; //16

            int wielkoscWymiaruPierwszegoZkolei = tablicaTrzyWym.GetLength(0);

            tablicaDwuWm[0, 0] = "A";
            tablicaDwuWm[0, 1] = "B";

            tablicaDwuWm[1, 0] = "C";
            tablicaDwuWm[1, 1] = "D";

            tablicaDwuWm[2, 0] = "E";
            tablicaDwuWm[2, 1] = "F";

            tablicaDwuWm[3, 0] = "G";
            tablicaDwuWm[3, 1] = "H";

            // teraz te tablice mozemy wysliwetlic w konsoli 

            Console.WriteLine("----- sposob 1 -----");

            for (int i = 0; i < tablicaDwuWm.GetLength(0); i++)
            {
                for (int j = 0; j < tablicaDwuWm.GetLength(1); j++)
                    Console.Write(tablicaDwuWm[i,j] + " ");

                Console.WriteLine();
            }

            Console.WriteLine("----- sposob 2 -----");

            for (int i = 0; i < tablicaDwuWm.GetLength(1); i++)
            {
                for (int j = 0; j < tablicaDwuWm.GetLength(0); j++)
                    Console.Write(tablicaDwuWm[j,i] + " ");

                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
