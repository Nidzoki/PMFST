using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbezad3
{
    class Program
    {
        struct Student
        {
            public string ime, prezime;
            public int dob;

        }

        static void Ucitaj(Student[] niz)
        {
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine($"Unesite ime {i+1}.studenta:");
                niz[i].ime = Console.ReadLine();

                Console.WriteLine($"Unesite prezime {i + 1}.studenta:");
                niz[i].prezime = Console.ReadLine();

                Console.WriteLine($"Unesite godine {i + 1}.studenta:");

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out niz[i].dob) && niz[i].dob > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Unesite godine {i + 1}.studenta:");
                    }
                    
                }
            }
        }

        static void Ispis(Student[] niz)
        {
            
            foreach (Student s in niz)
            {
                Console.WriteLine($"Ime: {s.ime}\nPrezime: {s.prezime}\nDob:{s.dob}\n");
            }
        }

        static void Main(string[] args)
        {
            int n = 3;
            Student[] niz = new Student[n];

            Ucitaj(niz);

            Console.WriteLine("Ispis po starosti: ");

            Ispis(niz.OrderBy(x => x.dob).ToArray());
            Console.WriteLine("Ispis po imenu: ");
            Ispis(niz.OrderBy(x => x.ime).ToArray());

            Console.ReadKey();
        }
    }
}
