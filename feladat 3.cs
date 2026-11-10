using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Channels;

namespace Feladatok
{
    internal class feladat_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("feladat 3:");
            int szam = 7;
            int osszeg = 0;
            for (int i = 1; i < szam; i++)
            {
                osszeg  = osszeg + i;
            }

            Console.WriteLine(osszeg);
        }
    }
}
