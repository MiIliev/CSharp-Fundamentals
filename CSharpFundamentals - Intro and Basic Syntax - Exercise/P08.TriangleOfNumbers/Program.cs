namespace P08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int printedNumber = 1;
            for (int currentRow = 1; currentRow <= n; currentRow++)
            {
                for (int i = 0; i < printedNumber; i++)
                {
                    Console.Write($"{printedNumber} ");
                }
                printedNumber++;
                Console.WriteLine();
            }
        }
    }
}