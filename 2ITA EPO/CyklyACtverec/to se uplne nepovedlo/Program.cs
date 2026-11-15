using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace to_se_uplne_nepovedlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int nemamRadNegramoty = 0;
            while (true)
            {
                // načtu číslo A
                Console.WriteLine("Zadejte číslo A:");
                a = Convert.ToInt32(Console.ReadLine());

                //pokud je A sudé tak ho přičte do sumy
                if (a % 2 == 0)
                {
                    suma += a;
                    //vypíšeme násobky 2 menší jak suma
                    Console.WriteLine("Násobky 2 menší jak suma:");
                    for (int i = 0; i < suma; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                    //vypíšeme násobky 5 menší jak suma
                    Console.WriteLine("Násobky 5 menší jak suma:");
                    for (int i = 0; i < suma; i += 5)
                    {
                        Console.WriteLine(i);
                    }
                }

                else
                {
                    continue;
                }

                //načtu číslo B
                Console.WriteLine("Zadejte číslo B:");
                b = Convert.ToInt32(Console.ReadLine());

                //Pokud je B větší než A sečtu všechna čísla od A do B dělitelná A nebo B
                if (b > a)
                {
                    for (int i = a; i <= b; i++)
                    {
                        if (i % a == 0)
                        {
                            nemamRadNegramoty += i;
                            continue;
                        }
                        if (i % b == 0)
                        {
                            nemamRadNegramoty += i;
                        }
                    }
                }

                else
                {
                    continue;
                }

                //načtu číslo C
                Console.WriteLine("Zadejte číslo C:");
                c = Convert.ToInt32(Console.ReadLine());         

                //Pokud je C rovno 0 ukončí se hlavní smyčka
                if (c == 0)
                {
                    break;
                }

                //vykreslí se obvod čtverce o straně C, pokud je číslol záporné vynásobí se -1
                if (c < 1)
                {
                    c = c * -1; 
                }

                //horní strana čtverce
                for (int i = 0; i < c; i++)
                {
                    Console.Write("* ");
                }

                //levá a pravá strana čtverce
                for (int i = 0;i < c-2; i++)
                {
                    Console.WriteLine();
                    Console.Write("*");
                    for (int n  = 0; n < c-2; n++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(" * ");                    
                }

                //dolní strana čtverce
                Console.WriteLine();
                for (int i = 0; i < c; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            Console.WriteLine(nemamRadNegramoty);
            Console.ReadKey();
        }
    }
}