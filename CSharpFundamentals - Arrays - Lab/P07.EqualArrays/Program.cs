using System;

namespace P07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int lengthOfCheck = 0;
            int sumOfArray = 0;

            bool identicalArrays = true;
            bool firstArrayLonger = false;
            bool secondArrayLonger = false;
            bool arraysLengthIsEqual = false;

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        identicalArrays = false;
                        break;
                    }
                    else
                    {
                        sumOfArray += firstArray[i];
                    }
                }


            if (identicalArrays)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumOfArray}");
            }
        }
    }
}