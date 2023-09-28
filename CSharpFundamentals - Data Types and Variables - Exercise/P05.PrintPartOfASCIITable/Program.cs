namespace P05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit = int.Parse(Console.ReadLine());
            int upperLimit = int.Parse(Console.ReadLine());

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                char currentCharacter = (char)i;
                Console.Write(currentCharacter + " ");
            }
        }
    }
}