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
            // vystupni soubor
            string vstupniSoubor = @"H:\test1.txt";

            // zkotroluji existenci vstupniho souboru
            if (File.Exists(vstupniSoubor))
            {
                

                int nejmensi = int.MaxValue;
                double soucet = 0;
                int pocLich = 0;
                int pocVys = 0;
                int pocMen = 0;

                // otevru cteci proud
                using (StreamReader sr = File.OpenText(vstupniSoubor))
                {
                    string radek;
                    int poradi = 1;

                    while ((radek = sr.ReadLine()) != null)
                    {              
                        int cislo = Int32.Parse(radek);

                        if (poradi % 2 != 0)
                        {
                            //hledam 
                            if (cislo < nejmensi)
                            {
                                nejmensi = cislo;
                            }

                            soucet = soucet + cislo;
                            pocLich++;
                        }

                        poradi++;
                    }
                }

                // prumer
                double prumer = soucet / pocLich;

                // otevreme soubor znova
                using (StreamReader sr = File.OpenText(vstupniSoubor))
                {
                    string radek;

                    while ((radek = sr.ReadLine()) != null)
                    {
                        int cislo = Int32.Parse(radek);

                        // kolikrat se vyskytuje nejmensi cislo v souboru
                        if (cislo == nejmensi)
                        {
                            pocVys++;
                        }

                        // cisla mensi nez prumer
                        if (cislo < prumer)
                        {
                            pocMen++;
                        }
                    }
                }
                //Zapis do vystupu

                //cesta k vystupnimu souboru
                string vystupniSoubor = @"H:\vysledky.txt";

                //otevreme zapisovaci proud
                using (StreamWriter sw = File.CreateText(vystupniSoubor))
                { 
                    // vypisu vysledky
                    sw.WriteLine("Nejmensi cislo na lichych radcich: " + nejmensi);
                sw.WriteLine("Prumer cisel na lichych radcich: " + prumer);
                sw.WriteLine("Pocet vyskytu nejmensiho cisla: " + pocVys);
                sw.WriteLine("Pocet cisel mensich nez prumer: " + pocMen);
                    sw.Close();
               
                }
                Console.WriteLine("hotovo");

            }
            else
            {
                // Kdyz soubor nebyl nalezen
                Console.WriteLine("Soubor nebyl nalezen.");
            }

            Console.ReadKey();
        }
    }
}