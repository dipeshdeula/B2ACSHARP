using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Generics
{
    internal class GenericDemo
    {
       /* public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }*/

     /*   static void Main()
        {*/
            /*
            int x = 5, y = 6;
            Console.WriteLine($"Before swapping: x={x}, y={y}");
            Swap<int>(ref x, ref y);
            Console.WriteLine($"After swapping: x={x}, y={y}");*/

            /*    int i = 0, j = 0;
            l1: while (i < 2)
                {
                    i++;
                    while (j < 3)
                    {
                        Console.WriteLine("loop\n");
                        goto l1;
                    }


                }
                Console.ReadLine();
            */
            /*int i, s = 0;
            for (i = 1; i <= 10; s = s + i, i++)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();*/

            /* int n, r;
             n = Convert.ToInt32(Console.ReadLine());

             while (n > 0)
             {
                 r = n % 10;
                 n = n / 10;
                 Console.WriteLine(+r);
             }
             Console.ReadLine();*/

           /* byte varA = 10;
            byte varB = 20;
            long result = varA & varB;
            Console.WriteLine("{0} AND {1} Result:{2}",varA,varB,result);
            varA = 10;
            varB = 10;
            result = varA * varB;
            Console.WriteLine("{0} AND {1} Result:{2}",varA,varB,result);
            Console.ReadLine();

        }*/
    }
}
