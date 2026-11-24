using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Feladatok
{
    internal class Feladat_11
    {
        static void Main(string[] args)
        {
            int[] szam = [1, 3, -4, -10, -1];

            int i = 0;
            while (i < szam.Length && szam[i] > -5)
            {
                i++;
            }
            
            
            if (i < szam.Length) {
                Console.WriteLine($"van ilyen: {szam[i]}");
            }
            else { Console.WriteLine("nincs ilyen"); }

            
        }
    }
}