using System.Text;

namespace P05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            if (firstNumber == "0" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int remainder = 0;
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(firstNumber[i].ToString());
                int product = digit * secondNumber + remainder;
                int currentResult = product % 10;
                remainder = product / 10;
                result.Insert(0, currentResult);
            }
            if( remainder > 0)
            {
                result.Insert(0, remainder);
            }
            Console.WriteLine(result);
        }
    }
}