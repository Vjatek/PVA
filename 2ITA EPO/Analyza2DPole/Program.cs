using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jhfshnjgfhgdnshgnjfsanhgfngsdkfkghaghmjkfgzeufuzg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //načtu číslo m od uživatele
            int m = 0;
            while (m < 5 || m > 20)
            {
                Console.WriteLine("Zadejte počet čísel v poli, číslo od 5 do 20!");
                m = Convert.ToInt32(Console.ReadLine());
            }

            //načtu číslo n od uživatele
            int n = 0;
            while (n < 5 || n > 20)
            {
                Console.WriteLine("Zadejte počet polí, číslo od 5 do 20!");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int[,] pole = new int[n, m];
            Random pica = new Random();

            //naplneni pole
            float soucet = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    pole[i, j] = pica.Next(10, 51);
                    soucet += pole[i, j];
                    Console.Write(pole[i,j] + " ");
                }
                Console.WriteLine();
            }

            //průměr
            Console.WriteLine("průmerná hodnota v celém poli: " + soucet / (n*m)  ) ;

            //dotazovani o pozici X,Y v poli
            
            while (true)
            {
                //ziskani X
                int x = 21;
                while (x > n - 1)
                {
                    Console.WriteLine("Zadejte X, číslo menší než {0}!", n);
                    x = Convert.ToInt32(Console.ReadLine());          
                }

                int y = 21;
                while (y > m - 1)
                {
                    Console.WriteLine("Zadejte Y, číslo menší než {0}!", m);
                    y = Convert.ToInt32(Console.ReadLine());
                }

                //pokud je x nebo y zaporne, ukonci se smycka
                if (x < 0 || y < 0)
                {
                    break;
                }

                //vypisu cislo na pozici X,Y
                Console.WriteLine(pole[x, y]);

                int mensi = 0;
                int vetsi = 0;
                int rovno = 0;
                
                for (int a = 0;a < n;a++)
                {
                    for(int b = 0; b < m;b++)
                    {
                        if (pole[a, b] < pole[x, y])
                        {
                            mensi++;
                        }
                        else if (pole[a, b] > pole[x, y])
                        {
                            vetsi++;
                        }
                        else
                        {
                            rovno++;
                        }
                    }
                }
                Console.WriteLine("Počet čísel menších jak {0}: {1}", pole[x, y], mensi);
                Console.WriteLine("Počet větších čísel: " + vetsi);
                Console.WriteLine("Počet stejných čísel: " + rovno);
            }

        }
    }
}
