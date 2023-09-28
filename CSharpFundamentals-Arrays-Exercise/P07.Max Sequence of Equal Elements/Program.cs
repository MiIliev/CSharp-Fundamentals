namespace P07.Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            int highestCounter = int.MinValue;
            int element = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (highestCounter < counter)
                {
                    highestCounter = counter;
                    element = inputArray[i];
                }
                counter = 0;
            }
            for (int i = 0; i < highestCounter; i++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}