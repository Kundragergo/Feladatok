using System;
using System.Collections.Generic;
using System.Text;

namespace Feladatok
{
    internal class feladat_2
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] betuk = ["a", "b", "c"];

            string szoveg = "";

            Console.WriteLine("Feladat 2.:");
            for (int i = 0; i < betuk.Length; i++)
            {
                szoveg += betuk[i];
            }
            Console.WriteLine(szoveg);
        }
    }
}
