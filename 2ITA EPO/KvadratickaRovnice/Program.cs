using System;
using System.Security.Policy;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -1, b = 2, c = 1;
            
            int D = b * b - 4 * a * c;
            if (D >= 0)
            {
                double x1 = -b + Math.Sqrt(D) / 2 * a;
                double x2 = -b - Math.Sqrt(D) / 2 * a;
                Console.WriteLine("x1: " + x1);
                Console.WriteLine("x2: " + x2);
            }

        }
    }
}