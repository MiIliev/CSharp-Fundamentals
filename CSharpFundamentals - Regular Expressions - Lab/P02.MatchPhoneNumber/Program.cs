using System.Text.RegularExpressions;

namespace P02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string filter = @"(\+359\s?2\s?[0-9]{3}\s?[0-9]{4}\b)|(\+359\-?2\-?[0-9]{3}\-?[0-9]{4}\b)";
            MatchCollection matches = Regex.Matches(input, filter);

            string[] matchedPhonnes = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhonnes));
        }
    }
}