using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vyhledavana
{
    internal class Program
    {
        static bool Naive(int[] pole, int hledany)
        {
            bool nalezeno = false;
            for (int i = 0; i < pole.Length; i++)
            {

                if (pole[i] == hledany)
                {
                    nalezeno = true; 
                }
            }
            return nalezeno;
        }
        static void Main(string[] args)
        {
            int[] pole = new int[10];

            Random rd = new Random();

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rd.Next(pole.Length);
                Console.Write($"{pole[i]} ");
            }

            Console.WriteLine();

            int hledany = 5;
            if (Naive(pole, hledany))
            {
                Console.WriteLine("cislo {hledany} nalezeno");
            }
            else
            {
                Console.WriteLine("cislo {hledany} nenalezeno");
            }
        }
    }
}
