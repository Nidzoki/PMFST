using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbezad4
{
    class Program
    {
        static int faktorijel(int n)
        {
            int f = 1;
            for (int i = 1; i < n+1; i++)
            {
                f *= i;
            }
            return f;
        }

        static int faktorijel_rekurzija(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else
            {
                return n * faktorijel_rekurzija(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int n, odabir;

            Console.WriteLine("Unesite cijeli broj:");

            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Unesite cijeli broj:");
                }
            }

            Console.WriteLine("Unesite broj metode 1 - iterativno, 2 - rekurzivno:");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out odabir) && odabir >=1 && odabir <= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Unesite broj metode 1 - iterativno, 2 - rekurzivno:");
                }
            }

            if(odabir == 1)
            {
                Console.WriteLine("Iterativno - " + faktorijel(n));
            }
            else
            {
                Console.WriteLine("Rekurzivno - " + faktorijel_rekurzija(n));
            }

            Console.ReadKey();
        }
    }
}
