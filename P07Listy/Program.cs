using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tablice mają stałą długość ! 

            string[] tablicaMiast = new string[3] { "warszawa", "kraków", "gdańsk" };

            // listy mają zmienną długość 

            List<string> listaPusta = null;

            //listaPusta.Add("..."); // użycie metody na liście pustej 
                                    // lub  na dowolnym innym obiekcie pustym 
                                    // zawsze generuje błąd 

            List<string> listaMiasta = new List<string>(); // ta lista ma 0 elementów

            listaMiasta.Add("warszawa");
            listaMiasta.Add("gdańsk"); // Add dodaje element na koniec listy 
            listaMiasta.Insert(1, "kraków"); // Insert dodaje na konkretną pozycję a pozostałe 
                                             // przesuwają się prawo 


            string miasto1=  listaMiasta[0];// pierwszy element 
            string miasto3 = listaMiasta[listaMiasta.Count - 1];

            listaMiasta.RemoveAt(1); // usuwam drugi z kolei element (liczby od 0)
            listaMiasta.Remove("gdańsk"); // usuwam pierwszy znaleziony gdańsk 
            
            //listaMiasta.RemoveAll()


        }
    }
}
