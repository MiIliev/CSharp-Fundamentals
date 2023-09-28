namespace P03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string sentence = Console.ReadLine();
            while (sentence.Contains(wordToRemove))
            {
                int indexOfWord = sentence.IndexOf(wordToRemove);            
                sentence = sentence.Remove(indexOfWord, wordToRemove.Length);
            }
            Console.WriteLine(sentence);
        }
    }
}