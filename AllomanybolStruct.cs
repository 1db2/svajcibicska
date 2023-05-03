using System;
using System.IO;

namespace Svajcibicska
{
    internal class Program
    {
        struct Sor
        {
            public string szoveg;
            public int szam;
        }
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("forras.txt");
            Sor[] sorok = new Sor[file.Length];

            for (int i = 0; i < file.Length; i++)
            {
                string[] adatok = file[i].Split(',');
                sorok[i].szoveg = adatok[0];
                sorok[i].szam = int.Parse(adatok[1]);
            }
        }
    }
}
