namespace P08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();  
            while (mainArray.Length > 1)
            {
                int[] condensedArray = new int[mainArray.Length];
                for (int j = 0; j < condensedArray.Length-1; j++)
                {
                    condensedArray[j] = mainArray[j] + mainArray[j + 1];
                }
                Array.Resize(ref condensedArray, condensedArray.Length - 1);
                Array.Resize(ref mainArray, mainArray.Length - 1);
                mainArray = condensedArray;
            }
            Console.WriteLine(mainArray[0]);
        }
    }
}