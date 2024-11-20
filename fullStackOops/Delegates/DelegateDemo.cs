using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Delegates
{
    public delegate int MyDelegate(int x, int y);
    public delegate int Transformer(int x);
    public delegate void Delegate2(string x);
    internal class DelegateDemo
    {
        /*static void Main(string[] args)
        {
            //creating a delegate and assigning reference to a method
            Console.WriteLine("I am fine");

        }*/
        static void Transform(int[] arr, Transformer t)
        {
            int c = 0;
            foreach (int i in arr)
            {
                arr[c++] = t(i);
            }
        }

        static int Square(int x) => x * x;
        static int Cube(int x) => x * x * x;
        static int add(int x, int y)
        {
            Console.WriteLine(x+y);
            return x + y;
        }

        static int sub(int x, int y)
        {
            Console.WriteLine(x - y);
            return x - y;
        }
    }
}
