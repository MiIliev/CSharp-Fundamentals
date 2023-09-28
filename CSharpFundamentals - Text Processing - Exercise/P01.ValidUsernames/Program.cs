namespace P02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();
            string firstWord = input[0];
            string secondWord = input[1];
            bool longerFirstWord = firstWord.Length > secondWord.Length;
            bool longerSecondWord = secondWord.Length > firstWord.Length;

            if (longerFirstWord)
            {
                sum = Multiply(secondWord, firstWord);
            }
            else
            {
                sum = Multiply(firstWord, secondWord);
            }
            Console.WriteLine(sum);

        }

        static double Multiply(string shorterWord, string longerWord)
        {
            double sum = 0;
            for (int i = 0; i < shorterWord.Length; i++)
            {
                double a = shorterWord[i];
                double b = longerWord[i];
                double multipliedResult = a * b;
                sum += multipliedResult;
            }
            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }
            return sum;
        }
    }
}