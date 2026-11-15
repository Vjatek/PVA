using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. funkce je část kodu kterou můžeme kdykoliv zavolat, musí obsahovat argumenty, datový typ a název funkce
  2. návratová hodnota je hodnota kterou vracíme z funkce pomocí return, musíme vracet datový typ který je v názvu funkce
  3. datový typ void nic neobsahuje a používáme ho u funkce kde nechceme vrátit žádnou hodnotu 
 */
namespace testasi
{
    internal class Program
    {
        static int CeleCislo(int minimum, int maximum)
        {
            while (true)
            { 
                int cislo = Convert.ToInt32(Console.ReadLine());
            if (cislo >= minimum && cislo <= maximum)
            {
                return cislo;
            }
            Console.WriteLine("Číslo musí být menší než {0} a větší než {1}!", maximum, minimum);
            }
        }

        static double desetinneCislo(double min, double max)
        {
            while (true)
            {
                double cislo = Convert.ToDouble(Console.ReadLine());
                if (cislo >= min && cislo <= max)
                {
                    return cislo;
                }
                Console.WriteLine("Číslo musí být menší než {0} a větší než {1}!", max, min);
            }
        }

        static double[] vytvoreniPole(int N, double A, double B)
        {
            Random nevimvubecnic = new Random();
            double[] pole = new double[N];
            for (int i = 0; i < N; i++)
            {
                pole[i] = (A + (nevimvubecnic.NextDouble()  * (B - A)));
                Console.WriteLine(pole[i]);
            }
            return pole;
        }

        static double prumery(double[] pole)
        {
            double cisilko = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                cisilko += pole[i];
            }
            double prumer = cisilko / pole.Length;
            return prumer;
        }

        static bool jeXvPoli(double[] pole, double X)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] == X)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte velikost pole, (5-20)");
            int N = CeleCislo(5, 20);

            Console.WriteLine("Zadejte minimum (1.0 - 50.0)");
            double A = desetinneCislo(1.0, 50.0);

            Console.WriteLine("Zadejte maximum ({0} - 50.0)", A);
            double B = desetinneCislo(A, 50.0);

            double[] pole = vytvoreniPole(N, A, B);

            Console.WriteLine("průměr celého pole: " + prumery(pole));

            int pocet = 0;
            while(true)
            {
                Console.WriteLine("Zadejte X, desetinné číslo: ");
                double cislo = desetinneCislo(0, B);
                if (cislo == 0)
                {
                    break;
                }

                bool xko = jeXvPoli(pole, cislo);
                if (xko)
                {
                    Console.WriteLine("Ano, nachází se");
                    pocet++;
                }
                else
                {
                    Console.WriteLine("Ne, nenachází se");
                }
            }
            Console.WriteLine("X bylo v poli {0} krát", pocet );
        }
    }
}

