namespace P01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            var counts = new SortedDictionary<int,int>();
            foreach (int number in numbers)
            {
                if (!(counts.ContainsKey(number)))
                {
                    counts[number] = 0;
                }
                counts[number]++;
            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}