namespace fullStackOops.StaticClass
{
    static class Calculator
    {
        private static int resultStorage = 0;
        public static string Type = "Arithmetic";
        public static int Sum(int num1, int num2) => num1 + num2;

        public static void Store(int result)
        {
            resultStorage = result;
            Console.WriteLine($"Result stored successfully i.e {resultStorage}");
        }
    }
}
