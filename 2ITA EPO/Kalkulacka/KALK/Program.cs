using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //výběr operace
            Console.WriteLine("Zadejte pozadovanou operaci:");
            string text = Console.ReadLine();
            int operace = Convert.ToInt32(text);

            Console.WriteLine("Zadaná operace:" + operace);

            if (operace == 1) //sčítání - a + b
            {   
                Console.WriteLine("Zadejte 1. číslo: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Zadejte 2. číslo: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Výsledek je: " + (a + b));
            }

            else if (operace == 2) //odčítání - a - b
            {
                Console.WriteLine("Zadejte 1. číslo: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Zadejte 2. číslo: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Výsledek je: " + (a - b));
            }

            else if (operace == 3) //dělení - a / b
            {
                Console.WriteLine("Zadejte 1. číslo: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Zadejte 2. číslo: ");
                float b = Convert.ToSingle(Console.ReadLine());
                if (b != 0)
                    {
                        Console.WriteLine("Výsledek je: " + (a / b));
                    }

                else
                {
                    Console.WriteLine("Nulou  nelze dělit debile");
                }
            }

            else if (operace == 4) //násobení - a * b
            {
                Console.WriteLine("Zadejte 1. číslo: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Zadejte 2. číslo: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Výsledek je: " + (a * b));
            }

            else if (operace == 5) //mocnina
            {
                Console.WriteLine("Zadejte 1. číslo: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Zadejte 2. číslo: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Výsledek je: " + (Math.Pow(a,b)));
            }

            else if (operace == 6) //odmocnina
            {
                Console.WriteLine("Zadejte 1. číslo: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Zadejte 2. číslo: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Výsledek je: " + (Math.Pow(a, 1/b)));
            }

            else if (operace == 7) //procento
            {
                Console.WriteLine("Zadejte 1. číslo: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Zadejte 2. číslo: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Výsledek je: " + (a % b));
            }

            else
            {
                Console.WriteLine("musí to být 1-7!!!");
            }
        }
    }
}
