namespace P01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var occurences = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!occurences.ContainsKey(input[i]) && input[i] != ' ')
                {
                    occurences.Add(input[i], 0);
                }
                if (input[i] != ' ')
                {
                    occurences[input[i]]++;
                }
            }
            foreach (var c in occurences)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}