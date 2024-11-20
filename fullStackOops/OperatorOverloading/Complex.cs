using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.OperatorOverloading
{
    internal class Complex
    {
        //Define Operator OverLoading:
        //A user-defined type can overload a predefined operator i.e,
        // a type can provide the custom implementation of an operation in case 
        //one or both of the operands are of that type. This is called operator overloading.
        private int x;
        private int y;
        public Complex() { }
        public Complex(int i, int j)
        {
            x = i;
            y = j;
        }
        public void Display()
        {
            Console.WriteLine("x = " + x + " y = " + y);
        }

        //Overloading unary operator
        public static Complex operator -(Complex c)
        {
            return new Complex(-c.x, -c.y);
        }
        //Overloading binary operator
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.x + c2.x, c1.y + c2.y);
        }

        /*static void Main(string[] args)
        {
            Complex c1 = new Complex(10, 20);
            c1.Display();
            Complex c2 = -c1;
            
            c2.Display();

            Complex c3 = new Complex(30, 40);
            c3.Display();
            Complex c4 = c2+ c3;
            c4.Display();

        }*/
    }
}
