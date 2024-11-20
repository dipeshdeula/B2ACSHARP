namespace fullStackOops.Polymorphism.MethodOverloading
{
    public class MathOperations
    {
        public int Add(int a) => a + 10;
        public int Add(int a, int b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;

        public double Add(int a, double b) => a + b;
    }
}
