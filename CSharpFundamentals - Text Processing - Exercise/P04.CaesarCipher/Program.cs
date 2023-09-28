using System.Text;

namespace P04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder cipheredText = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                cipheredText.Append((char)(currentChar+3));
            }
            Console.WriteLine(cipheredText.ToString());

        }
    }
}