using System.Text.RegularExpressions;

namespace P03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string filter = @"(?<Day>[0-9]{2})(?<Separator>[-.\/])(?<Month>[A-Z][a-z]{2})\2(?<Year>[0-9]{4})\b";
            MatchCollection matches = Regex.Matches(input, filter);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["Day"]}, Month: {match.Groups["Month"]}, Year: {match.Groups["Year"]}");
            }
        }
    }
}