namespace calculator_app1
{
    internal class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }
        static int subtract(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App");
            Console.WriteLine($"2 + 3 = {add(2, 3)}");
            Console.WriteLine($"5 + 2 = {subtract(5, 2)}");
        }
    }
}
