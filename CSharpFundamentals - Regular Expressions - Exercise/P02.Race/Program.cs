using System.Text;
using System.Text.RegularExpressions;

namespace P02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participantNames = Console.ReadLine()
                .Split(", ")
                .ToList();
            List<Participant> participantsResults = new List<Participant>();            
            foreach (string name in participantNames)
            {
                participantsResults.Add(new Participant(name, 0));
            }
            
            string input = null;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string letterFilter = @"[A-Za-z]";
                MatchCollection matchesLetter = Regex.Matches(input, letterFilter);
                StringBuilder name = new StringBuilder();
                foreach (var letter in matchesLetter)
                {
                    name.Append(letter);
                }
                if (participantNames.Contains(name.ToString()))
                {
                    participantsResults
                        .First(participant => participant.Name == name.ToString())
                        .Distance += AddKilometers(input);
                }
            }

            participantsResults = participantsResults.OrderByDescending(participant => participant.Distance).ToList();
            Console.WriteLine($"1st place: {participantsResults[0].Name}\n" +
                $"2nd place: {participantsResults[1].Name}\n" +
                $"3rd place: {participantsResults[2].Name}");
        }

        static int AddKilometers(string input)
        {
            int result = 0;
            string distanceFilter = @"\d";
            MatchCollection distanceMatches = Regex.Matches(input, distanceFilter);
            foreach (var digit in  distanceMatches)
            {
                int kilometer = int.Parse(digit.ToString());
                result += kilometer;
            }
            return result;
        }
    }

    public class Participant
    {
        public Participant(string name, int distance)
        {
            Name = name;
            Distance = distance;
        }

        public string Name { get; set; }
        public int Distance { get; set; }
    }
}