using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace soubor_max_cislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cesta k vstupnimu souboru
            string vstupniSoubor = @"C:\Users\vitdo\Documents\PVA\SOUBOR MAX CISLO\CISLA.txt";

            //kontrola existence souboru
            if (File.Exists(vstupniSoubor))
            {
                //soubor nalezen

                //budu hledat tri maxima
                int max1 = 0;
                int max2 = 0;
                int max3 = 0;

                //otevreme cteci proud
                using (StreamReader sr = File.OpenText(vstupniSoubor))
                {
                    //nacteme cely radek
                    string radek;
                    while ((radek = sr.ReadLine()) != null)
                    {
                        //nacetli jsme radek udelame z nej int
                        int cislo = Int32.Parse(radek);
                        //Console.WriteLine(cislo);

                        //hledame maxima
                        if (cislo > max1)
                        {
                            //posuneme stara maxima
                            max3 = max2;
                            max2 = max1;
                            //ulozime max1
                            max1 = cislo;
                        }
                        else if (cislo > max2)
                        {
                            //nasel jsem nove ma2
                            //posuneme stara maxima
                            max3 = max2;
                            //ulozime max2
                            max2 = cislo;
                        }
                        else if (cislo > max3)
                        {
                            //nasel jsem nove max3
                            //ulozime max3
                            max3 = cislo;

                        }

                    }
                    //uzavreme proud
                    sr.Close();
                }

                //vypis
                Console.WriteLine("Tri maxima jsou: " + max1 + ", " + max2 + ", " + max3);

            }
            else
            {
                //soubor nenalezen
                Console.WriteLine("Soubor nebyl nalezen.");
            }
        }
    }
}