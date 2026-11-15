using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int negr = 5;
            int negr2 = int.MinValue;
            while (negr != 0)
            {
                negr = Convert.ToInt32(Console.ReadLine());
                negr2 = negr > negr2 && negr != 0 ? negr: negr2 ;
            }

            Console.WriteLine(negr2);
            Console.ReadKey();  
        }
    }
}
    