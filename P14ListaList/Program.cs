using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ListaList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            List<List<string>> listaList = new List<List<string>>();

            List<List<List<string>>> listaListaList = new List<List<List<string>>>();

            listaList.Add(new List<string>());
            listaList[0].Add("A");
            listaList[0].Add("B");

            listaList.Add(new List<string>());
            listaList[1].Add("A");
            listaList[1].Add("B");
            listaList[1].Add("C");

            listaList.Add(new List<string>());
            listaList[2].Add("A");
            listaList[2].Add("B");

            listaList.Add(new List<string>() { "A", "B", "C" });


            // zapis klamerkowy 
            List<string> lista0 = new List<string>()
            {
                "ala","ma","kota"
            };

            List<List<string>> listaListNapisow = new List<List<string>>()
            {
                new List<string> {"A","B"},
                new List<string> {"C","D"},
                new List<string> {"E","F"},
            };

        }
    }
}
