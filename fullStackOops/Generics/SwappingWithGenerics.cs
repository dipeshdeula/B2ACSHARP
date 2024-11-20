namespace fullStackOops.Generics
{
    internal class SwappingWithGenerics
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        /*public static void Main(string[] args)
        {
            var DemoGeneric = new SwappingWithGenerics();

            //using with integers
            int x = 1, y = 2;
            DemoGeneric.Swap<int>(ref x, ref y);
            Console.WriteLine($"Swapped integers: x={x}, y={y}");

            //using with strings
            string first = "DEULA";
            string second = "TECH";
            DemoGeneric.Swap<string>(ref first, ref second);
            Console.WriteLine($"Swapped strings: first={first}, second={second}");
        }*/
    }
}
