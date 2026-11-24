using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Feladatok
{
    internal class Feladat_12
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> bevetel = new List<int>();

            for (int i = 0; i < 30; i++)
            {
                int r = rnd.Next(-2000, 2000);
                bevetel.Add(r);
            }

            int j = 0;
            while (j < bevetel.Count && bevetel[j] < 0)
            {
                j++;
            }
            
            
            if (j < bevetel.Count) {
                Console.WriteLine($"volt ilyen");
            }
            else { Console.WriteLine("nincs ilyen"); }

            
        }
    }
}