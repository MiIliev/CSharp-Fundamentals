namespace P03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = int.Parse(Console.ReadLine());
            var synonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                    synonyms[word].Add(synonym);
                }
                else if (!synonyms[word].Contains(synonym))
                {
                    synonyms[word].Add(synonym);
                }                               
            }
            foreach (var synonym in synonyms)
            {
                Console.WriteLine($"{synonym.Key} - {string.Join(", ", synonym.Value)}");
            }
        }
    }
}