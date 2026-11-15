using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Písemná_práce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte stranu a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte stranu b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte stranu c:");
            double c = Convert.ToDouble(Console.ReadLine());

            //trojúhelník
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("je trojúhelník");
                //strany
                if (a == b && b == c)
                {
                    Console.WriteLine("Je rovnostranný");
                }
                else if (a == b || b == c)
                {
                    Console.WriteLine("Je rovnoramenný");
                }
                else
                {
                    Console.WriteLine("Je různostranný");
                }

                //úhly
                if (((a * a) + (b * b)) > (c * c))
                {
                    Console.WriteLine("Je ostrý");
                }
                else if (((a * a) + (b * b)) == (c * c))
                {
                    Console.WriteLine("Je pravoúhlý");
                }
                else
                {
                    Console.WriteLine("Je tupoúhlý");
                }

                //obvod
                Console.WriteLine("Trojúhelník má obvod {0}", a + b + c);

                //obsah
                double s2 = (a + b + c) / 2;
                double S = Math.Sqrt(s2 * (s2 - a) * (s2 - b) * (s2 - c));
                Console.WriteLine("a obsah {0}", S);
            }
            else
            {
                Console.WriteLine("není trojúhelník!");
            }           
            Console.ReadKey();
        }
    }
}
