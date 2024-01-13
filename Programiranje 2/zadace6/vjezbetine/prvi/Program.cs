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
            int n;
            
            do
            {
                Console.WriteLine("Koliko rijeci zelite upisati?");
            }
            while (!int.TryParse(Console.ReadLine(), out n)) ;

            List<string> lista = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Upisite {i + 1} string:");

                lista.Add(Console.ReadLine());
            }
            Console.WriteLine("\nPalindromi:");

            foreach (string s in lista)
            {
                if (s.SequenceEqual(s.Reverse()))
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
