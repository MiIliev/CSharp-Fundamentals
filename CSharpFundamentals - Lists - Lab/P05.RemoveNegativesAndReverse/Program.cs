namespace P05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < input.Count; i++)

            {
                if (input[i] > 0)
                {
                    result.Add(input[i]);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}