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
            string s1 = list.Find( x => x[0] =='A'); //-------------- > EXPRESSAO LAMBDA 
                Console.Write("First 'A': " + s1);
            string s2 = list.FindLast(x => x[0] == 'A'); //-------------- > EXPRESSAO LAMBDA 
                Console.WriteLine("Last 'A': " +s2);
            int pos1 = list.FindIndex(x => x[0] == 'A'); //-------------- > EXPRESSAO LAMBDA
                Console.WriteLine("First position 'A': " + pos1);
            int post2 = list.FindLastIndex(x => x[0] == 'A'); //-------------- > EXPRESSAO LAMBDA
                Console.WriteLine("Last position 'A': " +post2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
                foreach(string obj in list2) {
                    Console.WriteLine(obj);
                }
            list.Remove("Alex");
            Console.WriteLine("------------------");
                foreach(string obj in list) {
                    Console.WriteLine(obj);
                }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------");
                foreach(string obj in list) {
                    Console.WriteLine(obj);
                }
            list.RemoveAt(3);
            Console.WriteLine("------------------");
                foreach(string obj in list) {
                    Console.WriteLine(obj);
                }
            list.RemoveRange(2, 2);
            Console.WriteLine("------------------");
                foreach(string obj in list) {
                    Console.WriteLine(obj);
                }          
        }
        static bool Test(string s) {
            return s[0] == 'A';
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
