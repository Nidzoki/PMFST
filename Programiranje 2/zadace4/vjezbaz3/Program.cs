using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = 10;

            int[] niz = new int[n];

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = r.Next(10,100);
            }

            niz = niz.OrderBy(x => x % 10 + x / 10).ToArray();

            foreach (int br in niz)
            {
                Console.WriteLine($"{br} - {br % 10 + br / 10}");
            }

            int min = niz[0] % 10 + niz[0] / 10;

            int odabrani = niz[0];

            foreach (int a in niz)
            {
                if (a % 10 + a / 10 > min)
                {
                    break;
                }
                else
                {
                    if (a < odabrani)
                    {
                        odabrani = a;
                    }
                }
            }

            Console.WriteLine($"Najmanji broj sa najmanjim zbrojem znamenki je {odabrani}.");

            Console.ReadKey();
        }
    }
}
