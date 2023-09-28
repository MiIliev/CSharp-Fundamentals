namespace P02.ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();
                switch (tokens[0])
                {
                    case "Delete":
                        int numberToBeRemoved = int.Parse(tokens[1]);
                        numbers.RemoveAll(item => item == int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        int element = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        numbers.Insert(position, element);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}