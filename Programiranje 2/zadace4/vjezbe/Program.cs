using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbe
{
    class Program
    {
        static bool Prost(int broj)
        {
            int i = 2;
            while (i < broj)
            {
                if (broj % i == 0)
                {
                    return false;
                }
                i++;
            }

            return true;

        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Unesite broj elemenata niza:");


            } while (!int.TryParse(Console.ReadLine(), out n) && n < 1);

            int[] niz = new int[n];
            for (int i = 0; i < niz.Length; i++)
            {
                
                do
                {
                    Console.WriteLine($"Unesi {i+1} broj:");
                } while (!int.TryParse(Console.ReadLine(), out niz[i]));
            }

            Console.WriteLine("Prosti brojevi koje ste unijeli:");

            foreach (int br in niz)
            {
                if (Prost(br))
                {
                    Console.WriteLine(br);
                }
                
            }

            Console.ReadKey();
        }
    }
}
