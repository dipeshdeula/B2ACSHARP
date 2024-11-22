using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace fullStackOops.Exception_Handling
{
    public class ExceptionDemo
    {
        static void Main(string[] args)
        {
           /* try
            {
                Console.WriteLine("Enter the number");
                int num = Convert.ToInt32(Console.ReadLine());
                int result = 10 / num;
                Console.WriteLine("result : {0} ", result);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception occured");
                Console.WriteLine(ex.Message);
            }
*/

          /*  int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("nums index at 7 , {0}", nums[7]);*/

            Console.WriteLine("Enter the size of array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter the number:");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}
