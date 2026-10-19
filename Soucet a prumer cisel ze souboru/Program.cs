using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace soucet_a_prumer_cisel_ze_souboru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstupniSoubor = @"C:\Users\vitdo\Documents\pvaaaa\VstupniSoubor.txt";
            //zkontroluji jestli vstupni soubor existuje
            if (File.Exists(vstupniSoubor))
            {
                //soubor byl nalezen
                

                using(StreamReader sr = File.OpenText(vstupniSoubor))
                {
                    //nacteme radek
                    double soucet = 0;
                    double pcr = 0;
                    double prumer = 0;
                    string radek;
                    while((radek = sr.ReadLine()) != null)
                    {
                        //prevedeme radek na cislo int
                        int cislo = Int32.Parse(radek);
                        soucet = soucet + cislo;
                        //pocet radku po kazdem prijeti pricteme +1
                        pcr++;
                        prumer = soucet / pcr;
                    }
                    //definice vystupniho souboru
                    string VystupniSoubor = @"C:\Users\vitdo\Documents\pvaaaa\VystupniSoubor.txt";
                    //vypsani prumeru a souctu do vystupniho souboru
                    using (StreamWriter sw = File.CreateText(VystupniSoubor))
                    {
                        sw.WriteLine("součet všech řádků je: " + soucet);
                        sw.WriteLine("počet řádků je: " +  pcr);
                        sw.WriteLine("průměr všech řádků je: " + prumer);
                        sw.Close();
                    }
                    Console.WriteLine("úspěšně zapsáno do výstupního souboru");
                }
            }
            else
            {
                //soubor nebyl nalezen
                Console.WriteLine("Vstupni soubor neexistuje");
            }
        }
    }
}
