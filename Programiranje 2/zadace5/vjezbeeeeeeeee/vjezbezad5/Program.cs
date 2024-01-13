using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbezad5
{
    class Program
    {
        static bool binarySearch(int n, int[] niz)
        {
            // nije dovrseno
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int n = 50;

            int[] niz = new int[n];

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = r.Next();
            }

            niz = niz.OrderBy(x => x).ToArray();

            Console.ReadKey();
        }
    }
}
