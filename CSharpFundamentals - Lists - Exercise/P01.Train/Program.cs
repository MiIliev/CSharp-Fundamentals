namespace P01.Train
{
    internal class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();
                if (tokens[0] == "Add")
                {
                    wagons.Add(int.Parse(tokens[1]));
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (passengers + wagons[i] <= maxCapacity)
                        {
                            wagons[i] = passengers + wagons[i];
                            break;
                        }
                    }                    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}