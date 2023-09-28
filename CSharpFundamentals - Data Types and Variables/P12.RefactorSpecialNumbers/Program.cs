namespace P12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberCount; i++)
            {
                int sum = 0;
                int number = i;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;
                }
                bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecialNum}");

            }
        }
    }
}