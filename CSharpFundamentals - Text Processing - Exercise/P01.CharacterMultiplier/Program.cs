namespace P01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ")
                .Where(x => x.Length >= 3 && x.Length <= 16)
                .Where(x => x.All(Char.IsLetterOrDigit) ||
                x.Contains("-") ||
                x.Contains("_"))
                .ToArray();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
