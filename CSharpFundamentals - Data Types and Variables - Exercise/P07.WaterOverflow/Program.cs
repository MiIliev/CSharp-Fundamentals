namespace P07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            for (int i = 0; i < lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                
                if (sum + liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += liters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}