using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        struct Skolarina
        {
            public string korisnik;
            public int ECTS;
            public double cijena;
        }

        static Skolarina[] UnesiSve(int n)
        {
            Skolarina[] niz = new Skolarina[n];

            for (int i = 0; i < niz.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Unesite ime {i + 1}. korisnika:");
                    niz[i].korisnik = Console.ReadLine();
                } while (niz[i].korisnik.Length < 3);

                do
                {
                    Console.WriteLine($"Unesite broj ECTS-a {i + 1}. korisnika:");
                    int.TryParse(Console.ReadLine(), out niz[i].ECTS);
                } while (niz[i].ECTS < 0 || niz[i].ECTS > 61);

                do
                {
                    Console.WriteLine($"Unesite cijenu ECTS-a {i + 1}. korisnika:");
                    double.TryParse(Console.ReadLine(), out niz[i].cijena);
                } while (niz[i].cijena <= 0);
            }

            return niz;
        }

        static Skolarina[] UnesiJedan()
        {
            int n;

            do
            {
                Console.WriteLine("Unesite broj skolarina:");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 2 || n > 20);


            Skolarina[] niz = new Skolarina[n];

            for (int i = 0; i < niz.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Unesite ime {i + 1}. korisnika:");
                    niz[i].korisnik = Console.ReadLine();
                } while (niz[i].korisnik.Length < 2);

                do
                {
                    Console.WriteLine($"Unesite broj ECTS-a {i + 1}. korisnika:");
                    int.TryParse(Console.ReadLine(), out niz[i].ECTS);
                } while (niz[i].ECTS < 0 || niz[i].ECTS > 61);

                do
                {
                    Console.WriteLine($"Unesite cijenu ECTS-a {i + 1}. korisnika:");
                    double.TryParse(Console.ReadLine(), out niz[i].cijena);
                } while (niz[i].cijena <= 0);
            }

            return niz;
        }

        static double Prosjek(Skolarina[] niz)
        {
            return niz.Average(x => x.ECTS);
        }

        static Skolarina Najblizi(Skolarina[] niz)
        {
            Skolarina trenutni = niz[0];

            foreach (Skolarina s in niz)
            {
                if (Math.Abs(s.ECTS - Prosjek(niz)) < Math.Abs(trenutni.ECTS - Prosjek(niz)))
                {
                    trenutni = s;
                }
            }
            return trenutni;
        }

        static double UkupnaSkolarina(Skolarina s)
        {
            return s.cijena * s.ECTS;
        }

        static Skolarina[] DvaNajvise(Skolarina[] niz)
        {
            niz = niz.OrderByDescending(x => UkupnaSkolarina(x)).ToArray();
            
            Skolarina[] dva = new Skolarina[2];
            dva[0] = niz[0];
            dva[1] = niz[1];

            return dva;
        }

        static int[] Prebroji(Skolarina[] niz)
        {
            int[] brojaci = new int[26];

            foreach (Skolarina s in niz)
            {
                brojaci[s.korisnik.ToUpper()[0- 'A']]++;
            }

            return brojaci;
        }

        static void Ladice(int[] brojaci)
        {
            for(int i = 0; i < brojaci.Length; i++)
            {
                if(brojaci[i] < 0)Console.WriteLine($"{(char)(i+'A')} : {brojaci[i]}");
            }
        }

        static void Main(string[] args)
        {/*
            int n;

            do
            {
                Console.WriteLine("Unesite broj skolarina:");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 2 || n > 20);
            
            Skolarina[] niz = UnesiSve(n);

            */
            // ispis

            Skolarina[] niz = UnesiJedan();

            foreach (Skolarina s in niz)
            {
                Console.WriteLine($"\n\nIme:{s.korisnik}\nBroj ECTS-a:{s.ECTS}\nCijena jednog ECTS-a:{s.cijena}\nUkupna skolarina:{UkupnaSkolarina(s)}");
            }

            Console.WriteLine($"\nProsjek ECTS-a je {Prosjek(niz)}");

            Console.WriteLine($"\nKorisnik najbliži prosjeku ECTS-a je {Najblizi(niz).korisnik}");

            Console.WriteLine($"Studenti koji placaju najvise su {DvaNajvise(niz)[0].korisnik} i {DvaNajvise(niz)[1].korisnik}.");

            //Ladice(Prebroji(niz));
            //ne radi

            Console.ReadKey();
        }
    }
}
