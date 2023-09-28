namespace P05.Top_Integers
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
            int[] topNumbers = new int[0];
            int remainingLengthToCheck = inputArray.Length - 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == inputArray.Length-1)
                {
                    Array.Resize(ref topNumbers, topNumbers.Length + 1);
                    topNumbers[^1] = inputArray[i];
                    break;
                }
                bool isTopNumber = false;
                for (int j = i+1; remainingLengthToCheck > 0; j++)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        isTopNumber = true;
                        remainingLengthToCheck--;
                    }
                    else
                    {
                        isTopNumber = false;                        
                        break;
                    }
                }
                if (isTopNumber)
                {
                    Array.Resize(ref topNumbers, topNumbers.Length +1);
                    remainingLengthToCheck = inputArray.Length - i - 2;
                    topNumbers[^1] = inputArray[i];
                }
                else
                {
                        remainingLengthToCheck = inputArray.Length - i - 2;
                }
            }
            Console.WriteLine(string.Join(' ', topNumbers));
        }
    }
}