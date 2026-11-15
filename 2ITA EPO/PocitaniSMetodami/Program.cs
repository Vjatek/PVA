using System;

namespace KalkulackaMetody
{
    internal class Program
    {
        static double NactiCislo()
        {
            Console.WriteLine("Zadejte číslo:");
            return Convert.ToDouble(Console.ReadLine());
        }

        static void VypisCislo(double n)
        {
            Console.WriteLine("Výsledek: {0}", n);
        }

        static double Secitani(double a, double b)
        {
            return a + b;
        }

        static double Odecitani(double a, double b)
        {
            return a - b;
        }

        static double Nasobilka(double a, double b)
        {
            return a * b;
        }

        static double Absolutni(double a)
        {
            if (a < 0)
            {
                return a * -1;
            }
            return a;
        }

        static double Faktorial(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("Číslo nesmí být záporné!");
                return 0;
            }
            double vysledek = 1;
            for (int i = 1; i <= a; i++)
            {
                vysledek *= i;
            }
            return vysledek;
        }

        static bool Pocitani()
        {
            Console.WriteLine("Zadej číslo operace (1 = +, 2 = -, 3 = *, 4 = abs, 5 = faktoriál, 0 = konec):");
            int operace = (int)NactiCislo();

            if (operace == 0)
            {
                return true; // Ukončí smyčku v Main
            }

            double vysledek = 0;

            switch (operace)
            {
                case 1:
                    vysledek = Secitani(NactiCislo(), NactiCislo());
                    break;
                case 2:
                    vysledek = Odecitani(NactiCislo(), NactiCislo());
                    break;
                case 3:
                    vysledek = Nasobilka(NactiCislo(), NactiCislo());
                    break;
                case 4:
                    vysledek = Absolutni(NactiCislo());
                    break;
                case 5:
                    vysledek = Faktorial((int)NactiCislo());
                    break;
                default:
                    Console.WriteLine("Neplatná operace!");
                    return false;
            }

            VypisCislo(vysledek);
            return false;
        }

        static void Main(string[] args)
        {
            while (!Pocitani()) { }
        }
    }
}