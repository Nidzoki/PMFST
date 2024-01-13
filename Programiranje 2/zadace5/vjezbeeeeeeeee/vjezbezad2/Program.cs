using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbezad2
{
    class Program
    {
        struct Knjiga
        {
            public string naslov, autor;
            public int ID;
            public double cijena;

        }
        static void Main(string[] args)
        {
            int n = 5;

            Knjiga[] niz = new Knjiga[n];
            Unos(niz);
            Ispis(niz);

            Console.WriteLine("Prosjek cijene je {0}", Prosjek(niz));

            Console.ReadKey();
        }

        private static void Unos(Knjiga[] niz)
        {
            Random r = new Random();

            for (int i = 0; i < niz.Length; i++)
            {

                niz[i].ID = r.Next(100, 1000);
                Console.WriteLine("Unesite ime knjige: ");
                niz[i].naslov = Console.ReadLine();

                Console.WriteLine("Unesite autora knjige: ");
                niz[i].autor = Console.ReadLine();

                Console.WriteLine("Unesite cijenu knjige: ");

                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out niz[i].cijena) && niz[i].cijena >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unesite cijenu knjige: ");
                    }
                }
            }

            
        }

        static void Ispis(Knjiga[] niz)
        {

            foreach (Knjiga k in niz)
            {
                Console.WriteLine($"ID: {k.ID}\nNaslov: {k.naslov}\nAutor: {k.autor}\nCijena: {k.cijena}");
            }
        }

        static double Prosjek(Knjiga[] niz)
        {
            double ukupna = 0;
            foreach (Knjiga k in niz)
            {
                ukupna += k.cijena;
            }

            return ukupna / niz.Length;
        }
    }
}
