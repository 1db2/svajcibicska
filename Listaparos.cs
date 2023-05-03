using System;
using System.Collections.Generic;

namespace Svajcibicska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();

            Random rng = new Random();

            for (int i = 0; i <= 29; i++)
            {
                int szam = rng.Next();
                szamok.Add(szam);
            }

            int paros = 0;
            foreach (int szam in szamok)
            {
                if (szam % 2 == 0)
                {
                    paros++;
                }
            }

            Console.WriteLine($"A listaban {paros} db paros szam van.");
        }
    }
}
