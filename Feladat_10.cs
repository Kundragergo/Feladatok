using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Feladatok
{
    internal class Feladat_9
    {
        static void Main(string[] args)
        {
            int[] evszamok = [1000, 1411, 1222, 1331, 1323];

            int i = 0;
            while (i < evszamok.Length && evszamok[i] != 1222)
            {
                i++;
            }
            
            
            if (i < evszamok.Length) {
                Console.WriteLine($"{i + 1}-.ik helyen van"); ;
            }
            else { Console.WriteLine("nincs benne"); }

            
        }
    }
}