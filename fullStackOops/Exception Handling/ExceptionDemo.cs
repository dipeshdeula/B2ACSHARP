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

            /*Console.WriteLine("Enter the size of array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            int num1 = 0;
            Console.WriteLine("Enter the number:");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if(num1 < arr[i])
                {
                    Console.WriteLine("Exception raised");
                    throw new Exception("Number is greater than 20");
                }

            }

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }*/

           /* Console.WriteLine("Please enter a number to divide 100:");

            try
            {
                int num = int.Parse(Console.ReadLine());
                int result = 100 / num;

                Console.WriteLine("100/{0}={1}", num, result);

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. Please try again");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation, please try again");

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid format, please try again");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error occured! please try again");
            }*/
        }
    }
}
