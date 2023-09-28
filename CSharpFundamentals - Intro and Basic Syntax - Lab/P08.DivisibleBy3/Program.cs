namespace P08.DivisibleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            for (int i = 0; i < 100; i++)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}