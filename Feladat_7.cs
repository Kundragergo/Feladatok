using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Feladatok
{
    internal class Feladat_7
    {
        static void Main(string[] args)
        {
            int[] szamok = [15, 99, 10, 3];

            bool van = false;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]  % 9 == 0)
                {
                    van = true;
                }
            }

            if (van) {
                Console.WriteLine("van 9-el osztható");
            }
            else
            {
                Console.WriteLine("nincs 9-cel osztható");
            }

        }
    }
}