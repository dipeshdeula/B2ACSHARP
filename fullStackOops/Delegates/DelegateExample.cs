//Step 1: Declare a delegate
delegate int CalculateDelegate(int num);

namespace fullStackOops.Delegates
{    
    internal class DelegateExample
    {
      
        static int number = 100;
        public static int Addition(int num)
        {
            number += num;
            return number;
        }

        public static int Multiply(int num)
        {
            number += num;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }

       /* public static void Main(string[] args)
        {
            //static method doesn't need instance to call
            Addition(20);
            Console.WriteLine(getNumber());

            //Step 2: Create a delegate object or set a target method
            CalculateDelegate c = new CalculateDelegate(Addition);
            CalculateDelegate c1 = new CalculateDelegate(Multiply);

            //step 3: Invoke a delegate
            c(10);
            Console.WriteLine(getNumber());
            c1(20);
            Console.WriteLine(getNumber());
            
        }*/


    }
}
