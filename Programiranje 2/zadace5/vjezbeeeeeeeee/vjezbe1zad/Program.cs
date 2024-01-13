using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbe1zad
{
    struct Tocka
    {
        public double x, y;

        public Tocka(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public double Udaljenost(Tocka b)
        {
            return Math.Sqrt((x - b.x) * (x - b.x) + (y - b.y) * (y - b.y));
        }
        
    }
    class Program
    {
        


        static void Main(string[] args)
        {
            Tocka a = new Tocka(0, 0), b = new Tocka(0, 0);

            // prva x koordinata
            Console.WriteLine("Unesite x koordinatu prve tocke:");
            while (true) 
            {
                if (double.TryParse(Console.ReadLine(), out double x1)) 
                {
                    a.x = x1;
                    break;
                }
                else
                {
                    Console.WriteLine("Unesite x koordinatu prve tocke:");
                }
            }

            // prva y koordinata

            Console.WriteLine("Unesite y koordinatu prve tocke:");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double y1))
                {
                    a.y = y1;
                    break;
                }
                else
                {
                    Console.WriteLine("Unesite x koordinatu prve tocke:");
                }
            }

            // druga x koordinata

            Console.WriteLine("Unesite x koordinatu druge tocke:");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double x2))
                {
                    b.x = x2;
                    break;
                }
                else
                {
                    Console.WriteLine("Unesite x koordinatu druge tocke:");
                }
            }

            // druga y koordinata

            Console.WriteLine("Unesite y koordinatu druge tocke:");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double y2))
                {
                    b.y = y2;
                    break;
                }
                else
                {
                    Console.WriteLine("Unesite y koordinatu druge tocke:");
                }
            }

            Console.WriteLine("Udaljenost izmedu tocaka je {0}", a.Udaljenost(b));

            Console.ReadKey();

        }
    }
}
