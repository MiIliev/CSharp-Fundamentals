﻿namespace P03.Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int[] roundedNumbers = new int[numbers.Length];

            for (int i = 0; i < roundedNumbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(numbers[i] + " => " + roundedNumbers[i]);
            }

        }
    }
}