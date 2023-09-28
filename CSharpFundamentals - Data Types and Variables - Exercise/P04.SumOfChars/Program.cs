namespace P04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charactersCount = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < charactersCount; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int charToInt = (int)currentChar;
                sum += charToInt;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}