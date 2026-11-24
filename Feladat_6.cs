using System;
using System.Collections.Generic;
using System.Text;

namespace Feladatok
{
    internal class Feladat_6
    {
        static void Main(string[] args)
        {
            int[] homerseklet = [20, 15, 5];

            int i = 0;

            while (homerseklet[i] > homerseklet[i + 1] && i <= homerseklet.Length - 1)
            {
                i++;
            }
            

            if (i == homerseklet.Length) {
                Console.WriteLine("nem csökken");
            }
            else
            {
                Console.WriteLine("csökken");
            }
        }
    }
}