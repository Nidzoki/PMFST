using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treci
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            int n;

            do
            {
                Console.WriteLine("Koliko slucajnih rijeci zelite?");
            } while (!int.TryParse(Console.ReadLine(), out n));

            string[] niz = new string[n];
            Console.WriteLine("Rijeci:");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    niz[i] += (Convert.ToChar(r.Next('A', 'Z' + 1)));
                }

                Console.WriteLine(niz[i]);
            }

            Console.WriteLine("Rijeci koje sadrze samoglasnike:");

            foreach (string s in niz)
            {
                if (s.Contains("A") || s.Contains("E") || s.Contains("I") || s.Contains("O") || s.Contains("U")) Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }    
}
