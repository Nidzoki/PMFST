using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbez2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; ;

            do
            {
                Console.WriteLine("Koliko rijeci zelite upisati:");
            } while (!int.TryParse(Console.ReadLine(), out n) && n < 1);
        
        string[] niz = new string[n];
        for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Upisite {i+1}. rijec:");
                niz[i] = Console.ReadLine();
			}
            niz = niz.OrderBy(x => x.Length).ToArray();

            foreach (string s in niz)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
