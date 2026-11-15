using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PisemnaPrace1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstupiSoubor = @"C:\Users\l20240034\Desktop\test1.txt";

            //pokud cesta k vstupnimu souboru existuje
            if (File.Exists(vstupiSoubor))
            {
                string radek;
                int cisloRadku = 0;
                float sudeMaximum = float.MinValue;
                float sudyPocet = 0;
                int sudeRadky = 0;               
                //cteci proud
                using (StreamReader sr = File.OpenText(vstupiSoubor))
                {
                    //dokud nenajdu prazdny radek, prochazim soubor radek po radku
                    while ((radek = sr.ReadLine()) != null)
                    {
                        float cislo = float.Parse(radek);
                        // zjistim jestli je radek sudy
                        if (cisloRadku % 2 == 0)
                        {
                            sudeRadky++;
                            //zjistim maximum
                            
                            if (cislo > sudeMaximum)
                            {
                                sudeMaximum = cislo;
                            }
                            
                            

                            sudyPocet += cislo;
                        }

                        cisloRadku++;
                    }
                    sr.Close();
                }
                //spocitam prumer
                float sudyPrumer = sudyPocet / sudeRadky;
                int pocetVyssichCisel = 0;
                float pocetMaxima = 0;

                //projdu soubor znova abych spocital cisla vyssi nez prumer
                using (StreamReader sr = File.OpenText(vstupiSoubor))
                { 
                    while ((radek = sr.ReadLine()) != null)
                    {
                        float cislo = float.Parse(radek);
                        if (cislo > sudyPrumer)
                        {
                            pocetVyssichCisel++;
                        }

                        //pokud se maximum opakuje zvysim celkovy pocet
                        if (cislo == sudeMaximum)
                        {
                            pocetMaxima++;
                        }
                    }
                    sr.Close();
                }

                //otevru psaci proud a vypisu vsechny vysledky co mam v zadani do soboru vystup.txt
                string vystupniSoubor = @"C:\Users\l20240034\Desktop\vystup.txt";
                using (StreamWriter sw = File.CreateText(vystupniSoubor))
                {
                    sw.WriteLine("maximum: " + sudeMaximum);
                    sw.WriteLine("prumer: " + sudyPrumer);
                    sw.WriteLine("pocetMaxim: " + pocetMaxima);
                    sw.WriteLine("pocet vyssich cisel jak prumer: " + pocetVyssichCisel);
                    sw.Close();
                }
                Console.WriteLine("hotovo");
            }

            //pokud zadam neplatnou cestu ke vstupnimu souboru tak mi to zde vypise
            else
            {
                Console.WriteLine("Cesta k souboru neexistuje");
            }
        }
    }
}
