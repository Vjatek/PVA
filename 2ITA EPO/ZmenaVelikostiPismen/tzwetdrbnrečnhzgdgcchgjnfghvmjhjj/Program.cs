using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tzwetdrbnrečnhzgdgcchgjnfghvmjhjj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nevim = "neiusadgsigzd AS B ndsd AQ56897t";

            for (int i = 0; i < nevim.Length; i++)
            {
                if (char.IsUpper(nevim[i]))
                {
                    char letter = char.ToLower(nevim[i]);
                    Console.WriteLine(letter);
                }

                else if (char.IsLower(nevim[i]))
                {
                    char letter = char.ToUpper(nevim[i]);
                    Console.WriteLine(letter);
                }       

                else
                {
                    Console.WriteLine(nevim[i]);
                }
            }
        }
    }
}
