namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ")
                .Select(x => x.ToLower())
                .ToArray();
            var counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts[word] = 0;
                }
                counts[word]++;
            }
            foreach(var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}