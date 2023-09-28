namespace P03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('\\', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Contains('.'))
                .ToArray();
            int dotIndex = input[0].IndexOf('.');
            string fileName = input[0].Remove(dotIndex, input[0].Length-dotIndex);
            string fileExtension = input[0].Remove(0, fileName.Length+1);
            Console.WriteLine($"File name: {fileName}\n" +
                $"File extension: {fileExtension}");
        }
    }
}