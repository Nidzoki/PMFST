using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetvrti
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, s;

            do
            {
                Console.WriteLine("Upisite broj redaka:");
            } while (!int.TryParse(Console.ReadLine(), out r) && r > 0);

            do
            {
                Console.WriteLine("Upisite broj stupaca:");
            } while (!int.TryParse(Console.ReadLine(), out s) && s > 0);

            int[,] matrica = new int[r, s];

            Random random = new Random();

            for(int i = 0; i < r; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    matrica[i, j] = random.Next();
                }
            }

            if (r == s)
            {
                int dvice = 0;
                foreach (int br in matrica)
                {
                    if (br == 2)
                    {
                        dvice++;
                    }
                }
                Console.WriteLine($"U matrici je {dvice} dvica.");
            }
            else
            {
                int max = 0,trenutni = 0;
                for (int i = 0; i < s; i++)
                {
                    int novi_max = 0;
                    for (int j = 0; j < r; j++)
                    {
                        if (matrica[j, i] == 2) novi_max++;
                    }
                    if (novi_max > max)
                    {
                        max = novi_max;
                        trenutni = i;
                    }
                }
                Console.WriteLine($"U {trenutni + 1} stupcu ima najvise dvica.");
            }
            Console.ReadKey();
        }
    }
}
