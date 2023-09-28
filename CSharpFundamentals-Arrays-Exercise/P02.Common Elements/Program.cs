namespace P02.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console
                .ReadLine()
                .Split()
                .ToArray();
            string[] secondArray = Console
                .ReadLine()
                .Split()
                .ToArray();
            string[] resultArray = new string[0];

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i] == firstArray[j])
                    {
                        Array.Resize(ref resultArray, resultArray.Length + 1);
                        resultArray[^1] = secondArray[i];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}