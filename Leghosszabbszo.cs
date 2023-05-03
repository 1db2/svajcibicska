using System;
using System.IO;
using System.Collections.Generic;

namespace Svajcibicska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("szavak.txt");

            List<string> szavak = new List<string>();

            foreach (string sor in sorok)
            {
                szavak.Add(sor);
            }

            string leghosszabbSzo = "";

            foreach (string szo in szavak)
            {
                if (szo.Length > leghosszabbSzo.Length)
                {
                    leghosszabbSzo = szo;
                }
            }

            Console.WriteLine($"A leghosszabb szo: {leghosszabbSzo}");
        }
    }
}
