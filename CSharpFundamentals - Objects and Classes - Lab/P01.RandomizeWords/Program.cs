namespace P01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine()
                .Split(" ")
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < sentence.Length; i++) 
            {
                string word = sentence[i];
                int randomIndex = random.Next(0, sentence.Length);
                string randomWord = sentence[randomIndex];
                sentence[i] = randomWord;
                sentence[randomIndex] = word;
            }
            foreach (string word in sentence)
            {
                Console.WriteLine(word);
            }
        }
    }
}