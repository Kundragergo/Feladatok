using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Feladatok
{
    internal class Feladat_8
    {
        static void Main(string[] args)
        {
            string[] honapok = ["január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december"];

            Console.Write("Írj be egy hónapot: ");
            string honap = Console.ReadLine();

            bool van = false;
            int sorszam  = 0;
            for (int i = 0; i < honapok.Length; i++) {
                if (honap == honapok[i]) {
                    van = true;
                    sorszam = i;
                    break;
                }
            }

            if (van) {
                Console.WriteLine($"Van ilyen hónap, {sorszam + 1}"); ;
            }
            else { Console.WriteLine("nincs"); }

            
        }
    }
}