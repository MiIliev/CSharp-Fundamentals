namespace P05.Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentnumber = numbers[i];
                if (currentnumber % 2 == 0)
                {
                    sumEven += currentnumber;
                }
                else
                {
                    sumOdd += currentnumber;
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}