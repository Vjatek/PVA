using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3maxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstupniSoubor = @"C:\Users\l20240034\Desktop\pokus.txt";
            if (File.Exists(vstupniSoubor))
            {
                int max1 = Int32.MinValue;
                int max2 = Int32.MinValue;
                int max3 = Int32.MinValue;
                string radek;
                using(StreamReader sr = File.OpenText(vstupniSoubor))
                {
                    while((radek = sr.ReadLine()) != null)
                    {
                        int cislo = Int32.Parse(radek);
                        Console.WriteLine(cislo);
                        if (cislo > max1 )
                        {
                            max2 = max3;
                            max2 = max1;
                            max1 = cislo;
                        }
                        else if (cislo < max1 && cislo > max2)
                        {
                            max3 = max2;
                            max2 = cislo;
                        }
                        else if (cislo < max2 &&cislo > max3)
                        {
                            max3 = cislo;
                        }
                    }
                    sr.Close();
                    
                }
                Console.WriteLine("{0}, {1}, {2}", max1, max2, max3);
            }
            else
            {
                Console.WriteLine("soubopr neni");
            }
        }
    }
}
