using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] spoluzaci = { "jirka", "michal", "ondřej", "vikotr", "danyjel", "petr" };
            for (int i = 0;i< spoluzaci.Length;i++)
            { Console.WriteLine(spoluzaci[i]); }
            /*
            Random negr = new Random();
            int[] pole8 = new int[negr.Next(0,100000)];
            for (int i = 0; i < pole8.Length; i++)
            { 
                pole8[i] = negr.Next(0,100000);
                Console.WriteLinwe(pole8[i]);
            }
            */
            int delkapicokundo = 90;
            long[] postupnost = new long[delkapicokundo];
            postupnost[0] = 1;
            postupnost[1] = 1;
            for (int i = 2;i<delkapicokundo;i++)
            {
                postupnost[i] = postupnost[i-1]+postupnost[i-2];
                Console.WriteLine(postupnost[i]);
            }


        }
    }
}
