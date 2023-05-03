using System;

namespace Svajcibicska
{
    internal class Program
    {
        struct Ember
        {
            public string nev;
            public int evszam;

            public Ember (string nev, int evszam)
            {
                this.nev = nev;
                this.evszam = evszam;
            }
        }
        static void Main(string[] args)
        {
            Ember[] emberek = new Ember[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Kerem adjon meg egy nevet: ");
                string nev = Console.ReadLine();
                Console.Clear();

                Console.Write("Kerem adjon meg egy evszamot: ");
                int evszam = int.Parse(Console.ReadLine());
                Console.Clear();

                emberek[i] = new Ember(nev, evszam);
            }

            Kiir(emberek);
        }

        static void Kiir(Ember[] emberek)
        {
            Console.WriteLine("Nev\tEvszam");
            foreach (Ember ember in emberek)
            {
                Console.WriteLine($"{ember.nev}\t{ember.evszam}");
            }
        }
    }
}
