namespace P07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatPhrase(phrase,number));
        }

        static string RepeatPhrase(string phrase, int numberOfRepetitions)
        {
            string repeatedPhrase = null;
            for (int i = 0; i < numberOfRepetitions; i++)
            {
                repeatedPhrase += phrase;
            }
            return repeatedPhrase;
        }

    }
}