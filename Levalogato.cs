using System;
using System.Collections.Generic;

namespace Svajcibicska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> kisebbMint25 = new List<int>();
            int[] szamok = new int[50];
            Random rnd = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(300);
            }

            foreach (int szam in szamok)
            {
                if (szam < 25 && szam % 3 == 0)
                {
                    kisebbMint25.Add(szam);
                }
            }

            if (kisebbMint25.Count == 0)
            {
                Console.WriteLine("Nincs 25-nel kisebb 3-mal oszthato szam a listaban.");
            }
            else
            {
                foreach (int szam in kisebbMint25)
                {
                    Console.WriteLine(szam);
                }

            }
        }
    }
}
