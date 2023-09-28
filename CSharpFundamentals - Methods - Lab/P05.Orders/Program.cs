namespace P05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            switch (product)
            {
                case "coffee":
                    Coffee(product, quantity); 
                    break;
                case "water":
                    Water(product, quantity);
                    break;
                case "coke":
                    Coke(product, quantity);
                    break;
                case "snacks":
                    Snacks(product, quantity);
                    break;
            }
        }

        static void Coffee(string product, int quantity)
        {
            double result = quantity * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        static void Water(string product, int quantity)
        {
            double result = quantity * 1.0;
            Console.WriteLine($"{result:f2}");
        }

        static void Coke(string product, int quantity)
        {
            double result = quantity * 1.4;
            Console.WriteLine($"{result:f2}");
        }
        static void Snacks(string product, int quantity)
        {
            double result = quantity * 2.0;
            Console.WriteLine($"{result:f2}");
        }
    }
}