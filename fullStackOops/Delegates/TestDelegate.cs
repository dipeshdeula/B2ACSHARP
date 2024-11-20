using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Delegates
{
    //deletage banauda tesko return type ra signature method sanga same hunu parxa
    public delegate void Show_Delegate();
    public delegate void Display(string name);
    public delegate void Calculate(int a, int b);
    

    internal class TestDelegate
    {
        public static void Show()
        {
            Console.WriteLine("Deleagate method called!");
        }
        public static void Display(string name)
        {
            Console.WriteLine("My name is : {0}",name);
        }
        public void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result: {0}", result);
        }

        public void Subtraction(int a, int b)
        { 
            int result = a - b;
            Console.WriteLine("Subtraction result: {0}",result);
        }

        public void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result: {0}", result);
        }

        public void Division(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed");
                }
                int result = a / b;
                Console.WriteLine("Division result: {0}", result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Message: {0}",e);
            }
           
        }

        public static string GetMessage()
        {
            return "Hello World!";
        }
        public static string GetMessage(string name)
        {
            return "Hello " + name;
        }

        public static string GetMessages(int roll)
        {
            return "Your id " + roll;
        }
     /*   static void Main(string[] args)
        {
            Show_Delegate sd = new Show_Delegate(Show);
            sd.Invoke();

            Display d = new Display(Display);
            d.Invoke("Dipesh");

            //create an instance of TestDelegate class
            TestDelegate td = new TestDelegate();

            Calculate c = new Calculate(td.Addition);
           *//* c.Invoke(5, 5); //10
            c(10, 20); //30

            c = td.Subtraction;
            c.Invoke(10, 5); //5

            c = td.Multiplication;
            c.Invoke(5, 5); //25

            c = td.Division;
            c.Invoke(10, 2); //5*//*

           //Mulitcast delegate
           c = td.Addition;
            c += td.Subtraction;
            c += td.Multiplication;
            c -= td.Division; // remove division method from delegate
            c(10, 5); // add:15, sub:5

            //func delegate
            Func<string> func = GetMessage;
            Console.WriteLine(func.Invoke());
            func = () => GetMessage("Dipesh");
            Console.WriteLine(func.Invoke());

            //parameter type, return tupe
            Func<int, string> funcP = GetMessages;
            Console.WriteLine(funcP.Invoke(1));


            //action delegate
            Action<int,int> funcAdd = td.Addition;
            funcAdd.Invoke(10, 20);


        }*/
    }
}
