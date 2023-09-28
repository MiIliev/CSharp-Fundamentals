using System.Text.RegularExpressions;

namespace P03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = "%(?<CustomerName>[A-Z][a-z]+)%(.*?)\\<(?<ProductName>\\w+)\\>(.*?)\\|(?<Count>[0-9]+)\\|(.*?)(?<Price>[\\d.]+)\\$";
            List<Product> products = new List<Product>();
            string input = null;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                MatchCollection matches = Regex.Matches(input, filter);
                foreach (Match match in matches)
                {
                    string customerName = match.Groups["CustomerName"].ToString();
                    string productName = match.Groups["ProductName"].ToString();
                    float count = float.Parse(match.Groups["Count"].ToString());
                    float price = float.Parse(match.Groups["Price"].ToString());
                    float total = count * price;
                    products.Add(new Product(customerName,productName, count, price));
                    Console.WriteLine($"{customerName}: {productName} - {total:f2}");
                }
            }
            float totalIncome = 0;
            foreach (Product product in products)
            {
                totalIncome += product.Total;
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }

        public class Product
        {
            public Product(string customerName, string productName, float count, float price)
            {
                CustomerName = customerName;
                ProductName = productName;
                Count = count;
                Price = price;
                Total = count * price;
            }

            public string CustomerName { get; set; }
            public string ProductName { get; set; }
            public float Count { get; set; }
            public float Price { get; set; }
            public float Total { get; set; }
        }
    }
}