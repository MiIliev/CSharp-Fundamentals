namespace P07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coinInput = null;
            string product = null;
            double sum = 0;
            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;

            while ((coinInput = Console.ReadLine()) != "Start")
            {
                if (coinInput == "0.1" || coinInput == "0.2" || coinInput == "0.5"
                    || coinInput == "1" || coinInput == "2")
                {
                    double coinInputDouble = double.Parse(coinInput);
                    sum += coinInputDouble;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinInput}");

                }
            }
            while ((product = Console.ReadLine()) != "End")
            {
                if (product == "Nuts")
                {
                    if (sum >= nutsPrice)
                    {
                        sum -= nutsPrice;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (sum >= waterPrice)
                    {
                        sum -= waterPrice;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (sum >= crispsPrice)
                    {
                        sum -= crispsPrice;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sum >= sodaPrice)
                    {
                        sum -= sodaPrice;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (sum >= cokePrice)
                    {
                        sum -= cokePrice;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}