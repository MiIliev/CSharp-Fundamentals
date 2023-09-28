using System.Text.RegularExpressions;

namespace P02.EncryptingPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            string filter = "(?<Chars>.+)\\>(?<numbers>[0-9]{3})\\|(?<lowerLetter>[a-z]{3})\\|(?<upperLetter>[A-Z]{3})\\|(?<symbols>[^\\<\\>]{3})\\<\\1$";
            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, filter);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"Password: " +
                            $"{match.Groups["numbers"]}" +
                            $"{match.Groups["lowerLetter"]}" +
                            $"{match.Groups["upperLetter"]}" +
                            $"{match.Groups["symbols"]}");
                    }
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }


    }
}