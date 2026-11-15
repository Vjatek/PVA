using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilujuROblox123
{
    internal class Program
    {

        static int soucet(int a, int b)
        {
            return a + b;
        }

        static int odecetina(int a, int b)
        {
            return a - b;
        }

        static int kokotina(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }

        static Random MilujuHouzyho = new Random();
        static float[] naplnPole1D(int velikost, float min, float max)
        {
            
            float[] pole = new float[velikost];

            for (int i = 0; i < velikost; i++)
            {
                pole[i] = (float)(min + (MilujuHouzyho.NextDouble() * (max - min)) );
            }

            return pole;
        }

        static void vypisPole1D(float[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
        }

        static float[] setrideni(float[] pole)
        {
            for (int i =0; i < pole.Length;i++)
            {
                for (int j = i; j < pole.Length; j++)
                {
                    if (pole[i] >    pole[j])
                    {
                        float nevim = pole[i];
                        pole[i] = pole[j];
                        pole[j] = nevim;
                    }
                }
            }
            return pole;
        }

        static void Main(string[] args)
        {
            float[] pole = naplnPole1D(10, 3, 8);
            pole = setrideni(pole);
            vypisPole1D(pole);
        }
    }
}