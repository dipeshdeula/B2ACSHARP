using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Exception_Handling
{
    internal class CalculationException
    {
        public void calculate(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
                Console.WriteLine("The result is :" + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured");
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("I will always execute");
                Console.WriteLine(result);
            }
            
        }

        public void CalculateAnother()
        {
            int num1, num2, result = 0;
            try
            {
                Console.WriteLine("Enter Number one:");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Number two:");
                num2 = int.Parse(Console.ReadLine());

                result = num1 / num2;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception occured");
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Exception occured");
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception occured");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I will always execute");
                Console.WriteLine(result);
            }
        }
       /* public static void Main(string[] args)
        {
            CalculationException calc = new CalculationException();
            calc.calculate(2, 2);
            calc.calculate(2, 0);

            CalculationException newCalc = new CalculationException();
            newCalc.CalculateAnother();
        }*/
    }
}
