namespace P09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int oddNumberSum = 0;
            while (n > 0)
            {
                Console.WriteLine(number);
                oddNumberSum += number;
                number += 2;
                n--;
            }

            Console.WriteLine($"Sum: {oddNumberSum}");
        }
    }
}