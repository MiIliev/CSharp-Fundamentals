using System.ComponentModel;

namespace P10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string number = input.ToString();
            if (number[0] == '-')
            {
                number = ConvertNegativeToPositive(number);
            }
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetSumOfOddDigits(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }

        static int GetSumOfEvenDigits(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(string number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }



        static string ConvertNegativeToPositive(string number)
        {
            string positiveNumber = null;
            
            for (int i = 0; i < number.Length - 1; i++)
            {
                    char tempChar = number[i + 1];
                    positiveNumber += tempChar;
            }
            return positiveNumber;
        }
    }
}