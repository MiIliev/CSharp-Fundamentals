using System.Text;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string furnitures = null;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                furnitures += input;
            }

            string filter = ">>(?<FurnitureName>[A-Za-z]+)<<(?<Price>[\\d.]+)!(?<Quantity>[0-9]+)\\b";
            MatchCollection matches = Regex.Matches(furnitures, filter);

            Console.WriteLine("Bought furniture:");
            double totalPrice = 0;
            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Groups["FurnitureName"]}");
                double costOfMatch = double.Parse(match.Groups["Price"].Value) * double.Parse(match.Groups["Quantity"].Value);
                totalPrice += costOfMatch;
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");

        }
    }
}