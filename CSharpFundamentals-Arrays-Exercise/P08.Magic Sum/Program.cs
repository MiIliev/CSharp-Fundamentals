namespace P08.Magic_Sum
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
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == inputArray.Length - 1)
                {
                    continue;
                }
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    int pairSum = inputArray[i] + inputArray[j];
                    if (pairSum == magicSum)
                    {
                        Console.WriteLine($"{inputArray[i]} {inputArray[j]}");
                    }
                }
            }
        }
    }
}