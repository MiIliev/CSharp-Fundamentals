namespace P04.Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console
                .ReadLine()
                .Split()
                .ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                string temp = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[^1] = temp;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}