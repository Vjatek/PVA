using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cesta k vstupnimu souboru
            string cestaKVstupnimuSouboru = @"H:\pva\projekt2\soubor.txt";

            //test existence
            if(File.Exists(cestaKVstupnimuSouboru))
            {
                Console.WriteLine("Soubor nalezen");

                //cesta k vystupnimu souboru
                string cestaKVystupnimusouboru = @"H:\pva\projekt2\kopie.txt";

                //cteci proud
                using (StreamReader sr = File.OpenText(cestaKVstupnimuSouboru))
                {
                    int cislo;

                    //vytvorime zapisovaci proud
                    using (StreamWriter sw = File.AppendText(cestaKVystupnimusouboru))
                    {
                        while( (cislo = sr.Read()) != -1)
                        {
                            string znak = Char.ConvertFromUtf32(cislo);
                            sw.Write(znak);
                        }
                        sw.Close();
                    }
                    sr.Close();

                }

                Console.WriteLine("kopirka");
            }
            else
            {
                Console.WriteLine("Soubor nenalezen");
            }

        }
    }
}
