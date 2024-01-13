using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugi
{
    class Program
    {
        struct Radnik
        {
            public string ime, prezime;
            public int god;
            public double placa;
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Koliko radnika zelite upisati?");
            } while (!int.TryParse(Console.ReadLine(), out n));

            Radnik[] lista = new Radnik[n];

            for (int i = 0; i < n; i++)
            {
                Random r = new Random();

                Console.WriteLine($"Unesite ime {i + 1} radnika:");
                lista[i].ime = Console.ReadLine();

                Console.WriteLine($"Unesite prezime {i + 1} radnika:");
                lista[i].prezime = Console.ReadLine();

                lista[i].god = r.Next(1950, 1994);

                do
                {
                    Console.WriteLine($"Unesite placu {i + 1} radnika:");

                } while (!double.TryParse(Console.ReadLine(), out lista[i].placa));

            }

            Console.WriteLine("\nRadnici:\n");

            foreach (Radnik r in lista)
            {
                Console.WriteLine($"Ime: {r.ime}\nPrezime: {r.prezime}\nGodiste: {r.god}\nPlaca: {r.placa}\n");
            }

            Console.WriteLine($"Prosjecna dob je {lista.Average(x => 2023 - x.god)} godina.");
            Console.WriteLine("\nRadnici kojima je povecana placa:");
            for (int i = 0; i < lista.Length; i++)
            {
                if (2023 - lista[i].god > lista.Average(x => 2023 - x.god))
                {
                    lista[i].placa *= 1.1;
                    Console.WriteLine(lista[i].ime + " " + lista[i].prezime);
                }

                
            }
            Console.ReadKey();
        }
    }
}
