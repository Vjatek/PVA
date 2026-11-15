using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polemultisim2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random kokot = new Random();
            int m = kokot.Next(5, 11);
            int n = m;
            int[,] cisilka = new int[m,n];

            int soucet = 0;

            for (int i = 0; i < m; i++)
            { 
                for (int k = 0; k<n; k++)
                {
                    cisilka[i,k] = kokot.Next(10,100);
                    Console.Write(cisilka[i, k]+" ");
                    soucet += cisilka[i, k];
                }
                Console.WriteLine();
            }

            int soucetosy1 = 0;          
            
            for (int i = 0; i < m; i++)
            {
                soucetosy1 += cisilka[i, i];
                
            }           

            int soucetosy2 = 0;
            for (int i = 0; i < m; i++)
            {           
                soucetosy2 += cisilka[i, m-i-1];
            }
            Console.WriteLine(soucet);
            Console.WriteLine("soucet prvni osy: " + soucetosy1);
            Console.WriteLine("soucet druhe osy: " + soucetosy2);

            int suda = 0;
            for (int i = 0;i < m;i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (cisilka[i, k] % 2 == 0)
                    {
                        suda += cisilka[i, k];
                    }
                }
            }
            Console.WriteLine("sudá čísla: " +  suda);
            */

            Random pica = new Random();
            int m = 4 ;
            int n = m;

            int[,] cisilka = new int[m, n];
            int cislopico = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    cisilka[i, j] = cislopico;
                    cislopico++;
                    Console.Write(cisilka[i, j] + " ");
                }
                Console.WriteLine();
            }

            int pomocna = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = i; j < n; j++)
                {
                    pomocna = cisilka[i, j];
                    cisilka[i, j] = cisilka[j, i];
                    cisilka[j, i] = pomocna;
                }
            }

            pomocna = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m-i-1; j++)
                {  
                    pomocna = cisilka[i, j];
                    cisilka[i, j] = cisilka[j, i];
                    cisilka[j, i] = pomocna;
                }
            }

            //vypis pole
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(cisilka[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
