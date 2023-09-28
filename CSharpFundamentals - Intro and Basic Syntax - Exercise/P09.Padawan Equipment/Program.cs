namespace P09.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ownedMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double totalPriceSaber = Math.Ceiling(countOfStudents * 1.1) * priceOfSaber;
            double totalPriceRobe = countOfStudents * priceOfRobe;

            int freeBelts = countOfStudents / 6;
            double totalPriceBelts = (countOfStudents - freeBelts) * priceOfBelt;

            double neededMoney = totalPriceBelts + totalPriceRobe + totalPriceSaber;

            if (neededMoney <= ownedMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {neededMoney - ownedMoney:f2}lv more.");
            }

        }
    }
}