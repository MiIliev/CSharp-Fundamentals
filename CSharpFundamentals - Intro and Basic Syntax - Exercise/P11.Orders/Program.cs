namespace P11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < ordersCount; i++) 
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                decimal priceCurrentOrder = (daysInMonth * capsulesCount) * pricePerCapsule;
                totalPrice += priceCurrentOrder;
                Console.WriteLine($"The price for the coffee is: ${priceCurrentOrder:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}