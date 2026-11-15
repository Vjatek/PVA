using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykly_breakdance
{
    internal class Program
    {
    static void Main(string[] args)
        {
            Random rnd = new Random();
            int vyhry = 0;
            int prohry = 0;

            //nekonečný loop
            while (true) 
            {
                //nové náhodné číslo
                int tajneCislo = rnd.Next(1, 100);
                int n = 0;

                //10 pokusů loop
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Zbývá:{0} pokusů", 10 - i);
                    n = Convert.ToInt32(Console.ReadLine());

                    //nalezeni
                    if (n == tajneCislo)
                    {
                        Console.WriteLine("Nalezeno");
                        vyhry++;
                        prohry--;
                        break;
                    }

                    //uhodnuté číslo je větší
                    if (n > tajneCislo)
                    {
                        Console.WriteLine("Je menší");
                    }

                    //uhodnuté číslo je menší jak 0 - ukončení programu
                    else if (n < 0)
                    {
                        string vyherce = ((vyhry > prohry) ? "Hráč vyhrál" : (vyhry == prohry) ? "Remíza" : "Počítač vyhrál");
                        Console.WriteLine("{2} Vyhry:{0}, Prohry: {1}", vyhry, prohry, vyherce);
                        return;
                    }

                    //uhodnuté číslo je menší
                    else
                    {
                        Console.WriteLine("je větší");
                    }
                    
                }
                prohry++;
            }         
        }             
    }
}
