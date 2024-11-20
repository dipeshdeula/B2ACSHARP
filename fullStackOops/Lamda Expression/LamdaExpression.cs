using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Lamda_Expression
{
    internal class LamdaExpression
    {
        //Note: lambda expression introuduced in c# 3.0
        /*static void Main(string[] args)
        {*/
            //Expression lamda

            /* var numbers = new int[] { 2, 3, 4, 5, 6, 7, 8 };
             var count = numbers.Count(x => x > 5);
             Console.WriteLine("Expression lamda: " + count);

             //statement lamda
             List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
             count = numbers2.Count((int x) =>
             {
                 if (x > 5)
                     return true;
                 else
                     return false;
             });

             Console.WriteLine("Statemtnt lamda: " + count);

             //fucn delegate in lamda expression
             //<taken no. of parameter, return type>
             Func<int,int> sqr = x => x * x;
             Console.WriteLine("Square of 5 is: " + sqr(5));

             //taking two or more parameter
             Func<string,string,int> totalLengt = (a, b) => a.Length + b.Length;
             Console.WriteLine("Total length of two string is: " + totalLengt("Dipesh", "Ramesh"));
 */

            //odd or even number using lamda expression
            /* Console.WriteLine("Enter the number:");
             int num = Convert.ToInt32(Console.ReadLine());
             Func<int, string> oddEven = x =>
             {
                 if (x % 2 == 0)
                     return "Even";
                 else
                     return "Odd";
             };
             Console.WriteLine("Number is: " + oddEven(num));*/

            // Prime not prime using lambda expression

            /*   Console.WriteLine("Enter the number:");
               int num = Convert.ToInt32(Console.ReadLine());
               Func<int, string> prime = x =>
               {
                   if (x == 1)
                       return "Not Prime";
                   for (int i = 2; i <= x / 2; i++)
                   {
                       if (x % i == 0)
                           return "Not Prime";
                   }
                   return "Prime";
               };
               Console.WriteLine(prime(num));*/

            /* var u = (int a) => (a % 2 == 0) ? "even" : "odd";

             Console.WriteLine(u(5));*/

            //Action delegate using lambda expression : 
          /*  Action<int> print = x => Console.WriteLine(x);
            print(10);
            Action<string>Details = x => Console.WriteLine("Name: " + x);
            Details("Dipesh");

            //predicate delegate using lambda expression : return only boolean type
            Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine(isEven(5));

            Predicate<string> isUpper = x => x.Equals(x.ToUpper());
            Console.WriteLine(isUpper("aA"));*/

            /*
             1. The Func delegate takes zero, one or more input parameters, and returns a value(with its out parameter).
             2. The action takes zero, one or more input parameters, but does not return anything.
             3. The predicate is a special kind of Func. It represents a method that contains a set of criteria and checks whether the passed parameter meets those criteria mostly defined inside an if condition 
                and checks whether the passed parameter meets those criteria or not
    
            It takes one input parmaeter and returns a boolean -true or false.

            Note: 
             
            */


       /* }*/


    }
}
