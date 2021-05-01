using System;
using System.Collections.Generic;
namespace EXERCICE_02___LIST_M._06 {
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>(); //-------------- > DECLARAÇÃO DA LISTA 

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list) { //-------------- > PRINTA OS OBJETOS DA LISTA
                Console.WriteLine(obj);
            }
            Console.Write("list count: " + list.Count);

            string s1 = list.Find( x => x[0] =='A'); //-------------- > LAMBDA 
            Console.Write("First 'A': " + s1);
        }
        static bool Test(string s) {
            return s[0] == 'A';
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
