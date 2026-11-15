using System;
using System.Security.Permissions;

namespace podminky35
{
    internal class Program
   {
        static void Main(string[] args)
        { 
            int pocetBodu = Convert.ToInt32(Console.ReadLine());
            if (pocetBodu <= 100 && pocetBodu >= 90)
            {
                Console.WriteLine("máš 1");
            }
            else if (pocetBodu <= 89 && pocetBodu >= 80)
            {
                Console.WriteLine("2 ty nulo");
            }
            else if (pocetBodu <= 79 && pocetBodu >= 70)
            {
                Console.WriteLine("máš 3");
            }
            else if (pocetBodu <= 69 && pocetBodu > 60)
            {
                Console.WriteLine("za 4 debile");
            }
            else if (pocetBodu <= 59 && pocetBodu >= 0)
            {
                Console.WriteLine("krásná 5");
            }
            else
            {
                Console.WriteLine("to asi nejde brácho");
            }

            int a = 5;
            int b = 10;

            string vysledek = (a == b) ? "rovno" : ((a > b) ? "A" : "B");
            Console.WriteLine(vysledek);
        }
    }   
}