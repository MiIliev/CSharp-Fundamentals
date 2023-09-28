namespace P03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int length = Math.Max(firstList.Count(), secondList.Count());
            for (int i = 0; i < length; i++)
            {
                if (i+1 <= firstList.Count())
                {
                    result.Add(firstList[i]);
                }
                if (i+1 <= secondList.Count())
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}