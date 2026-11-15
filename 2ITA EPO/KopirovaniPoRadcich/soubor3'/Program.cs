using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace soubor3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string VstupniSoubor = @"C:\Users\l20240036\Desktop\pokus.txt";

            //kontrola existence 
            if (File.Exists(VstupniSoubor))
            {
                string vystupniSoubor = @"C:\Users\l20240036\Desktop\kopie.txt";
                int pocetRadku = 0;

                using (StreamReader sr = File.OpenText(VstupniSoubor))
                {

                    using (StreamWriter sw = File.CreateText(vystupniSoubor))
                    {
                        string radek;
                        while((radek = sr.ReadLine()) != null)
                        {
                            pocetRadku++;
                            sw.Write(radek + Environment.NewLine);
                        }

                        sw.Close();
                    }

                    sr.Close();
                }
                Console.WriteLine("bylo zkopirovano {0} radku pico", pocetRadku);
            }
            else
            {
                Console.WriteLine("soubor nenalezen");
            }
        }
    }
}
