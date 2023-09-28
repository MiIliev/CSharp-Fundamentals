namespace P04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopPyramid(number);
            PrintBottomPyramid(number - 1);
        }

        static void PrintTopPyramid(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintBottomPyramid(int number)
        {
            for (int row = number; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }

    }
}