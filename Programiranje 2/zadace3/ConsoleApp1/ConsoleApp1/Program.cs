using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Prost(int br)
        {
            int i = 2;

            while(i < br) { if (br % i == 0) return false; i++; }
                    

            return true;
        }

        

        static void Main(string[] args)
        {
            int broj = 0;
            // 1. zadatak
            do
            {
                Console.Write("Unesi broj u rasponu [2,100]:");

                int.TryParse(Console.ReadLine(), out broj);

                if (broj < 2 || broj > 100)
                {
                    Console.WriteLine("\n Broj je izvan granica, pokusaj ponovo.");
                }
                
            }
            while (broj < 2 || broj > 100);

            Console.WriteLine($"\nUnijeli ste broj {broj}!");

            // 2. zadatak

            if (Prost(broj))
            {
                Console.WriteLine("Broj je prost.");
            }
            else
            {
                Console.WriteLine("Broj nije prost.");
            }

            // 3. zadatak
            Console.WriteLine("\nProsti brojevi manji od 100: ");
            for (int i = 1; i < 100; i++)
            {
                if (Prost(i))
                {
                    Console.WriteLine(i);
                }
            }

            // 4. zadatak
            Random r = new Random();
            broj = r.Next(0, 100);
            Console.WriteLine("\nOdreden je slucajni broj {0}\n", broj);

            // 5. zadatak
            broj = r.Next(0, 100);
            Console.WriteLine("Racunalo je odredilo novi nepoznati slucajni broj od 0 do 100!");
            int uneseni = -1;
            bool flag = false;
            do
            {
                if (uneseni > broj)
                {
                    Console.WriteLine("Uneseni broj je veci od slucajnog broja.");
                }
                else
                {
                    Console.WriteLine("Uneseni broj je manji od slucajnog broja.");
                }
                Console.WriteLine();
                Console.WriteLine("Probajte pogoditi broj:");
                flag = int.TryParse(Console.ReadLine(), out uneseni);
            } while (uneseni != broj);

            Console.WriteLine("Pogodili ste broj!");

            

            // 6. zadatak

            List<int> lista = new List<int>();

            Console.WriteLine("\nOdabrani su brojevi:");

            for (int i = 0; i < 10; i++)
            {
                int random = r.Next(0, 100);
                
                Console.WriteLine(random);
                lista.Add(random);
            }
            Console.WriteLine($"Najveci je {lista.Max()}, a najmanji je {lista.Min()}");

            Console.ReadKey();
        }
    }
}
