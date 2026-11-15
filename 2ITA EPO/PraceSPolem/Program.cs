using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace pole_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] pole = new int[5];   
            Random rnd = new Random();
            int fudfatudhasdtrafjdnhastbdhařdgauzdhnaz = 0;
            int zaporna = 0;
            int nulycigani = 0;
            
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = Convert.ToInt32(Console.ReadLine());
                
                if (pole[i] > 0)
                {
                    fudfatudhasdtrafjdnhastbdhařdgauzdhnaz++;
                }
                else if (pole[i] < 0)
                {
                    zaporna++;
                }
                else
                {
                    nulycigani++;
                }
            }
                
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % 2 == 0)
                { 
                Console.WriteLine("číslo {0} na indexu {1} je sudé", pole[i], i);
                }
            }
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % 2 != 0)
                {
                    Console.WriteLine("číslo {0} na indexu {1} je liché", pole[i], i);
                }
            }
            Console.WriteLine("kladna:{0}, zaporna: {1}, nuly: {2}", fudfatudhasdtrafjdnhastbdhařdgauzdhnaz, zaporna, nulycigani);

            */
            /*
            Random negr = new Random();
            int jedna = 0;           
            string[] nevim2 = { "jirka", "michal", "prazdnemisto", "vikotr", "danyjel", "ja" };
            for (int i = 0; i < nevim2.Length;i++)
            {
                jedna = negr.Next(nevim2.Length);
                string nevim = nevim2[i];               
                nevim2[i] = nevim2[jedna];
                nevim2[jedna] = nevim;

            }
            

            for (int i = 0; i < nevim2.Length; i++)
            {
                Console.WriteLine(nevim2 [i]);
            }
            */

            
            
            int[] nevim2 = new int[5];

            int posun = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nevim2.Length; i++)
            {
                
                int nevim = nevim2[i];
                if (i + posun < nevim2.Length)
                {
                    
                    nevim2[i] = nevim2[i + posun];
                    
                    nevim2[i + posun] = nevim;
                }
                else
                {
                    nevim2[i] = nevim2[nevim2.Length - (i + posun)];
                    nevim2[nevim2.Length - (i + posun)] = nevim;
                }

            }


            for (int i = 0; i < nevim2.Length; i++)
            {
                Console.WriteLine(nevim2[i]);
            }
        }
    }
}
