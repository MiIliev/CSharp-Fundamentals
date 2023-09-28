namespace P03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            switch (action)
            {
                case "add":
                    Console.WriteLine(Add(x, y));
                    break;
                case "multiply":
                    Console.WriteLine(Multiply(x, y));
                    break;
                case "subtract":
                    Console.WriteLine(Subtract(x, y));
                    break;
                case "divide":
                    Console.WriteLine(Divide(x, y));
                    break;
            }
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}