using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podminky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            if ((b != 0) && (a%2 == 0))
            {
                Console.WriteLine(a/b);
            }

            else 
            {
                Console.WriteLine("neplatné");
            }
        }
    }
}