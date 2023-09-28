namespace P10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier < 11)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int result = number * i;
                    Console.WriteLine($"{number} X {i} = {result}");
                }
            }
            else if (multiplier > 10)
            {
                int result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
            }

        }
    }
}