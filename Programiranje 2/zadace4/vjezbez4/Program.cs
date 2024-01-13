using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbez4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int m = r.Next(3, 8), n = r.Next(3, 8);
            int[,] matrica = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrica[i, j] = r.Next(0, 10);
                }
            }

            for (int i = 0; i < m; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrica[i, j] + " ");
                }
                Console.WriteLine("");
            }

            if(m == n)
            {
                int trag = 0;

                for (int i = 0; i < m; i++)
                {
                    trag += matrica[i, i];
                }

                Console.WriteLine($"Trag matrice je {trag}");
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < n; i++)
                {
                    suma += matrica[m-1, i];
                }
                Console.WriteLine($"Suma zadnjeg retka u matrici je {suma}");
            }

            Console.ReadKey();
        }
    }
}
