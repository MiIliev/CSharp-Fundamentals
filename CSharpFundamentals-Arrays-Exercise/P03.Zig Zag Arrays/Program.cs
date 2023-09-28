namespace P03.Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool firstArrayTurn = true;
            int[] firstArray = new int[0];
            int[] secondArray = new int[0];

            for (int i = 0; i < lines; i++)
            {
                int[] input = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
             if (firstArrayTurn)
                {
                    Array.Resize(ref firstArray, firstArray.Length +1);
                    Array.Resize(ref secondArray, secondArray.Length + 1);
                    firstArray[i] = input[0];
                    secondArray[i] = input[1];
                    firstArrayTurn = false;
                }
                else
                {
                    Array.Resize(ref firstArray, firstArray.Length + 1);
                    Array.Resize(ref secondArray, secondArray.Length + 1);
                    firstArray[i] = input[1];
                    secondArray[i] = input[0];
                    firstArrayTurn = true;
                }
            }
            Console.WriteLine(string.Join(' ',firstArray));
            Console.WriteLine(string.Join(' ', secondArray));
        }
    }
}