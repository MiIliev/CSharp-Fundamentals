using System.Text;

namespace P04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            
            foreach (var bannedWord in bannedWords)
            {
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));
            }
            Console.WriteLine(text.ToString());
        }
    }
}