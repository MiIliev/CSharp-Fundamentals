namespace P01.StringManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string input = null;
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> command = input
                    .Split(" ")
                    .ToList();
                switch (command[0])
                {
                    case "Translate":
                        sentence = sentence.Replace(command[1], command[2]);
                        Console.WriteLine(sentence);
                        break;
                    case "Includes":
                        Console.WriteLine(sentence.Contains(command[1]));
                        break;
                    case "Start":
                        Console.WriteLine(sentence.StartsWith(command[1]));
                        break;
                    case "Lowercase":
                        sentence = sentence.ToLower();
                        Console.WriteLine(sentence);
                        break;
                    case "FindIndex":
                        Console.WriteLine(sentence.LastIndexOf(command[1]));
                        break;
                    case "Remove":
                        sentence = sentence.Remove(int.Parse(command[1]), int.Parse(command[2]));
                        Console.WriteLine(sentence);
                        break;
                }
            }
        }
    }
}