using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ObslugaBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;

            string s = "ala";
           
            try
            {
                double c = a / b;
                string s1 = s.Substring(3, 1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("podałeś błedny indeks");
                File.AppendAllText("c:\\dane\\errors\\errorlog.txt",Environment.NewLine+ ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("nie mozesz dzielić przez zero");
                File.AppendAllText("c:\\dane\\errors\\errorlog.txt", Environment.NewLine + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Coś poszło nie tak");
                File.AppendAllText("c:\\dane\\errors\\errorlog.txt", Environment.NewLine + ex.Message);
            }

            Console.ReadKey();

        }
    }
}
