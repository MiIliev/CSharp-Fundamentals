namespace P03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < numbersCount; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}