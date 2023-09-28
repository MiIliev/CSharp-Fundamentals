namespace P03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double costPerPerson = 0;
            double totalCost = 0;

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    costPerPerson = 8.45;
                    if (count >= 30)
                    {
                        totalCost = count * costPerPerson * 0.85;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }
                }
                else if (type == "Business")
                {
                    costPerPerson = 10.90;
                    if (count >= 100)
                    {
                        count -= 10;
                        totalCost = count * costPerPerson;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }

                }
                else if (type == "Regular")
                {
                    costPerPerson = 15;
                    if (count >= 10 && count <= 20)
                    {
                        totalCost = count * costPerPerson * 0.95;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    costPerPerson = 9.80;
                    if (count >= 30)
                    {
                        totalCost = count * costPerPerson * 0.85;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }
                }
                else if (type == "Business")
                {
                    costPerPerson = 15.60;
                    if (count >= 100)
                    {
                        count -= 10;
                        totalCost = count * costPerPerson;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }
                }
                else if (type == "Regular")
                {
                    costPerPerson = 20;
                    if (count >= 10 && count <= 20)
                    {
                        totalCost = count * costPerPerson * 0.95;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    costPerPerson = 10.46;
                    if (count >= 30)
                    {
                        totalCost = count * costPerPerson * 0.85;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }
                }
                else if (type == "Business")
                {
                    costPerPerson = 16;
                    if (count >= 100)
                    {
                        count -= 10;
                        totalCost = count * costPerPerson;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }
                }
                else if (type == "Regular")
                {
                    costPerPerson = 22.50;
                    if (count >= 10 && count <= 20)
                    {
                        totalCost = count * costPerPerson * 0.95;
                    }
                    else
                    {
                        totalCost = count * costPerPerson;
                    }
                }
            }
            Console.WriteLine($"Total price: {totalCost:f2}");
        }
    }
}