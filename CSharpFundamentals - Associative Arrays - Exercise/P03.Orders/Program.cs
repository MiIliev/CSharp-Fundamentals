namespace P03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string input = null;

            while ((input=Console.ReadLine()) != "buy")
            {
                string[] inputToArray = input
                    .Split()
                    .ToArray();
                string name = inputToArray[0];
                double price = double.Parse(inputToArray[1]);
                int quantity = int.Parse(inputToArray[2]);
                Product product = new Product(price, quantity);
                if (!products.ContainsKey(name))
                {
                    products.Add(name, product);
                }
                else
                {
                    int newQuantity = products[name].Quantity + quantity;
                    products[name] = new Product(price, newQuantity);
                }
            }
            foreach (var kvp in products)
            {
                double totalPrice = kvp.Value.Price * kvp.Value.Quantity;
                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
            }
        }
    }

    public class Product
    {
        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;

        }

        public double Price { get; set; }
        public int Quantity { get; set; }

    }
}