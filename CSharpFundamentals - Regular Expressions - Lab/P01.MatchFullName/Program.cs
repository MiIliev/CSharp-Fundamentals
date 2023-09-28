using System.Text.RegularExpressions;

namespace P01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string filter = @"(?<FirstName>\b[A-Z][a-z]+) (?<SecondName>[A-Z][a-z]+)";
            MatchCollection matches = Regex.Matches(input, filter);

            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}