using System;
using System.Collections.Generic;
using System.Text;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Hetnapjai = ["hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat", "vasárnap"];

            Console.Write("egy szó: ");
            string szo = Console.ReadLine();


            bool talalt = false;
            for (int i = 0; i < Hetnapjai.Length; i++)
            {
                if (szo == Hetnapjai[i])
                {
                    talalt = true;
                }
            }


            if (talalt)
            {
                Console.WriteLine("talált");
            }
            else
            {
                Console.WriteLine("nem talált");
            }
        }
    }
}