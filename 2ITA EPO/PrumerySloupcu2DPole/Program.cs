using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PoleMulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole1D = { 1, 2, 3 };
            int[,] pole2D =
            {   
                {11,12,13 },
                {12,14,15},
                {14,16,17},
            };

            int[,] pole2D2 = new int[3,3] ;

            Console.WriteLine(pole2D.GetLength(0));

            int[,] pole2D3 = new int[10, 10];
            Random kokot = new Random();
            double soucet = 0;

            for (int i = 0; i < pole2D3.GetLength(0); i++)
            {               

                for (int nevim = 0; nevim < pole2D3.GetLength(1); nevim++)
                {

                    pole2D3[i, nevim] = kokot.Next(0,101);
                    Console.Write(pole2D3[i, nevim] + " ");                   

                }

                Console.WriteLine();          
            }
            
            for (int picovina = 0; picovina < pole2D3.GetLength(1); picovina++)
            {
                for (int i = 0; i <pole2D3.GetLength(0); i++)
                {
                    soucet += pole2D3[i, picovina];    
                }
                Console.WriteLine("průměr {0}. čísel: {1}", picovina+1, soucet / pole2D3.GetLength(0));
                soucet = 0;
            }
        }
    }
}
