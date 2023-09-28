namespace P02.GeneratingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string input = null;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input
                    .Split(" ")
                    .ToArray();
                if (command[0] == "add")
                {
                    AddToStart(numbers, command);
                }
                else if (command[1] == "greater")
                {
                    numbers.RemoveAll(x => x > int.Parse(command[3]));
                }
                else if (command[0] == "replace")
                {
                    int index = numbers.IndexOf(int.Parse(command[1]));
                    numbers[index] = int.Parse(command[2]);
                }
                else if (command[1] == "at")
                {
                    if (int.Parse(command[3]) < numbers.Count - 1)
                    {
                        numbers.RemoveAt(int.Parse(command[3]));
                    }
                }
                else if (command[1] == "even")
                {
                    EvenOrOdd(numbers, command, true);
                }
                else if (command[1] == "odd")
                {
                    EvenOrOdd(numbers, command, false);
                }
                
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        static List<int> AddToStart(List<int> numbers, string[] command)
        {
            List<int> numbersToBeAdded = new List<int>();
            for (int i = command.Length - 1; i > 2; i--)
            {
                numbers.Insert(0, int.Parse(command[i]));
            }

            return numbers;
        }
        static void EvenOrOdd(List<int> numbers, string[] command, bool evenNumbers)
        {
            List<int> numbersToPrint = new List<int>();
            if (evenNumbers)
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        numbersToPrint.Add(number);
                    }
                }
            }
            else
            {
                foreach (int number in numbers)
                {
                    if (number % 2 != 0)
                    {
                        numbersToPrint.Add(number);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbersToPrint));

            
        }
    }
}