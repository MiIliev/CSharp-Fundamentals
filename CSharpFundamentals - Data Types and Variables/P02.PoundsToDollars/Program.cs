namespace P02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dollar = 1.31m;
            Console.WriteLine($"{pound * dollar:f3}");
        }
    }
}