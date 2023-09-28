namespace P06.ListOfManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
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
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int numberRemoveAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(numberRemoveAt);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index, numberToInsert);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}