using System;
using System.Collections.Generic;

namespace Svajcibicska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> szovegek = new List<string>();
            string szoveg = "";

            do
            {
                szoveg = Console.ReadLine();
                
                if (szoveg != "")
                {
                    szovegek.Add(szoveg);
                }
            } while (szoveg != "");
        }
    }
}
