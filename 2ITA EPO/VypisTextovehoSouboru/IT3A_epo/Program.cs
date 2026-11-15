using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3A_epo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cesta k souboru
            string cestaKSouboru = "C:\\Users\\l20240034\\desktop\\pokus.txt";

            //test existence souboru
            if(File.Exists(cestaKSouboru))
            {
                Console.WriteLine("Soubor nalezen");

                //do souboru pripojime proud (ctecka text. souboru)
                using (StreamReader sr = File.OpenText(cestaKSouboru))
                {
                    int cislo;
                    //jdeme cist znak po znaku
                    while((cislo = sr.Read())!= -1)
                    {
                        //prevedeme na znak
                        string znak = char.ConvertFromUtf32(cislo);
                        //vytiskni
                        Console.Write(znak);

                    }
                    //uzavreme cteci proud
                    sr.Close();
                }
            }
            else
            {
                //soubor na zadane ceste neexistuje
                Console.WriteLine("Soubor nenalezen");
            }
        }
    }
}
