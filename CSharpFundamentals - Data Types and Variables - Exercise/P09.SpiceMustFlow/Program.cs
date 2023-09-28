namespace P09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int producedYield = int.Parse(Console.ReadLine());
            int days = 0;
            int sumSpice = 0;

            while (producedYield >= 100)
            {
                int collectedYield = producedYield - 26;
                sumSpice += collectedYield;
                producedYield -= 10;
                days++;
            }
            Console.WriteLine(days);
            sumSpice -= 26;
            if (sumSpice < 0)
            {
                sumSpice = 0;
            }
            Console.WriteLine(sumSpice);
        }
    }
}