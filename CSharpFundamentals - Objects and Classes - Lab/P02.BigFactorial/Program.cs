using System.Numerics;

namespace P02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial.ToString());
        }
    }
}