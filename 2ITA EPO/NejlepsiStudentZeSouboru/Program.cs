using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace studenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstupniSoubor = @"C:\Users\l20240036\Desktop\studenti.txt";
            string hledanaTrida = "IT3A";

            if (File.Exists(vstupniSoubor))
            {

                using (StreamReader sr = File.OpenText(vstupniSoubor))
                {
                    string radek;
                    string nejlepsiJmeno = "";
                    float nejlepsiPrumer = 5.0f;
                    while ((radek = sr.ReadLine()) != null)
                    {

                        string[] sloupce = radek.Split(';');

                        if (hledanaTrida == sloupce[1] && nejlepsiPrumer > float.Parse(sloupce[2]))
                        {
                            nejlepsiPrumer = float.Parse(sloupce[2]);
                            nejlepsiJmeno = sloupce[0];
                        }
                        Console.WriteLine("Prijmeni: " +  sloupce[0]);
                        Console.WriteLine("trida: " + sloupce[1]);
                        Console.WriteLine("Prumer: " + sloupce[2]);
                        /*
                        string prijmeni = "";
                        int i = 0;
                        while (radek[i] != ';')
                        {
                            prijmeni += radek[i];
                            i++;
                        }
                        Console.WriteLine(prijmeni);
                        */

                    }

                    Console.WriteLine(nejlepsiJmeno);
                    sr.Close();
                }
            
            }
        }
    }
}
