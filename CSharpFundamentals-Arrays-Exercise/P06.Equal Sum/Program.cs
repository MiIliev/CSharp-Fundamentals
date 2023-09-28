namespace P06.Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            bool noSuchNumbers = true;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (j != i && j !> i)
                    {
                        sumLeft += inputArray[j];
                    }
                    else if (j != i && j !< i)
                    {
                        sumRight += inputArray[j];
                    }
                }
                if (sumLeft == sumRight)
                {
                    Console.Write($"{i} ");
                    if (noSuchNumbers)
                    {
                        noSuchNumbers = false;
                    }
                }
                sumLeft = 0;
                sumRight = 0;
            }
            if (noSuchNumbers)
            {
                Console.WriteLine("no");
            }
        }
    }
}