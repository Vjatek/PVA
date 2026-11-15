using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace statistika_des_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstupniSoubor = @"C:\Users\l20240034\Desktop\desetinna cisla.txt";
            string vystupniSoubor = @"C:\Users\l20240034\Desktop\vystupni soubor.txt";
            if (File.Exists(vstupniSoubor)) 
            {
                using (StreamReader sr = File.OpenText(vstupniSoubor))
                {
                    double min = Double.MaxValue;
                    double max = Double.MinValue;
                    int pocet = 0;
                    double cisilko = 0;
                    
                    double prumerCely = 0;
                    while ((sr.ReadLine()) != null)
                    {           
                        double cislo = Convert.ToDouble(sr.ReadLine());
                        //min
                        if (cislo < min)
                        {
                            min = cislo;
                        }

                        //max
                        if (cislo > max)
                        {
                            max = cislo;
                        }

                        cisilko += cislo;
                        pocet++;
                    }

                    
                    prumerCely = cisilko / pocet;
                    double prumer = (min + max) / 2;

                    using (StreamWriter sw = File.CreateText(vystupniSoubor))
                    {
                        sw.WriteLine("minimum:" +  min);
                        sw.WriteLine("maximum:" + max);
                        sw.WriteLine("prumer z min a max:"+ prumer);
                        sw.WriteLine("prumer ze vsech:"+ prumerCely);
                        sw.Close();
                    }
                sr.Close();
                }
            }
        }
    }
}
