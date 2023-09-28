using System.Transactions;

namespace CSharpFundamentals___List___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> numbers = Console.ReadLine()
                .Split()
                .Select(float.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + 1 < numbers.Count)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        i = -1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}