using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaNombres = { "Death Knight", "Priest", "Druid", "Hunter" };

            IEnumerable<string> shortNames = from s in listaNombres
                                             where s.Length <= 5
                                             orderby s select s.ToUpper();
            Console.WriteLine("Nombres cortos de rango 5:");
            foreach (string item in shortNames)
                Console.WriteLine(item);

            //Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Nombres que empiezan con D:");

            string[] empienzanConLetra = listaNombres.Where(s => s[0] == 'D').ToArray();

            foreach (string item in empienzanConLetra)
                Console.WriteLine(item);
            // Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("Ordenados alfabeticamente:");
            var ordenados = listaNombres.OrderBy(s => s);
            var ordenadosDesc = listaNombres.OrderByDescending(s => s);

            foreach (string item in ordenados)
                Console.WriteLine(item);

            Console.WriteLine("");
            Console.WriteLine("Ordenados alfabeticamente descendete:");
            foreach (string item in ordenadosDesc)
                Console.WriteLine(item);
            Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Nombres ordenados por tamaño");

            var tamnho = listaNombres.OrderBy(s => s.Length);
            var tamnhoDesc = listaNombres.OrderByDescending(s => s.Length);

            foreach (string item in tamnho)
                Console.WriteLine(item);
            Console.ReadLine();

            Console.WriteLine("Nombres ordenados por tamaño mayor");
            foreach (string item in tamnhoDesc)
                Console.WriteLine(item);
            //Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("Nombres agrupados por tamaño");

            var groups = listaNombres.GroupBy(s => s.Length);
            foreach (IGrouping<int,string>group in groups)
            {
                Console.WriteLine("Nombres con longitud: {0}", group.Key);
                foreach (string value in group)
                    Console.WriteLine(" {0}", value);
            }
            Console.ReadLine();
        }
    }
}
