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

            List<int> originalNumbers = numbers.ToList();
            bool changesMadeToOriginalList = false;

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        changesMadeToOriginalList = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        changesMadeToOriginalList = true;
                        break;
                    case "RemoveAt":
                        int numberRemoveAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(numberRemoveAt);
                        changesMadeToOriginalList = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index, numberToInsert);
                        changesMadeToOriginalList = true;
                        break;
                    case "Contains":
                        Console.WriteLine(Contains(tokens, numbers));
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", PrintEven(numbers)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", PrintOdd(numbers)));
                        break;
                    case "GetSum":
                        Console.WriteLine(GetSum(numbers));
                        break;
                    case "Filter":
                        Console.WriteLine(string.Join(" ", Filter(tokens, numbers)));
                        break;
                }
                input = Console.ReadLine();
            }
            if (changesMadeToOriginalList && numbers != originalNumbers)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static string Contains(string[] tokens, List<int> numbers)
        {
            int numberContained = int.Parse(tokens[1]);
            if (numbers.Contains(numberContained))
            {
                return "Yes";
            }
            else
            {
                return "No such number";
            }
        }

        static List<int> PrintEven(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            return evenNumbers;
        }

        static List<int> PrintOdd(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }
            return oddNumbers;
        }

        static int GetSum(List<int> numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static List<int> Filter(string[] tokens, List<int> numbers)
        {
            string condition = tokens[1];
            int numberToFiler = int.Parse(tokens[2]);
            List<int> filteredNumbers = new List<int>();

            if (condition == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < numberToFiler)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
            }
            else if (condition == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > numberToFiler)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }

            }
            else if (condition == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= numberToFiler)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= numberToFiler)
                    {
                        filteredNumbers.Add(numbers[i]);
                    }
                }
            }
            return filteredNumbers;
        }
    }
}

