using System.Reflection.Metadata;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> osztaly = new List<int>();

            Console.WriteLine("Feladat 1.:");
            for (int i = 0; i < 20; i++) { 
                int szam = rnd.Next(1, 6);
                osztaly.Add(szam);
            }

            double osszeg = 0;
            for (int i = 0; i < osztaly.Count; i++) { 
                osszeg += osztaly[i];
            }
            double atlag = Math.Round(osszeg / osztaly.Count, 2);
            Console.WriteLine($"{atlag}");
        }
    }
}
