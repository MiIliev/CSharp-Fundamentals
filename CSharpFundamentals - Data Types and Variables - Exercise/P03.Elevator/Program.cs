namespace P03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double coursesNeeded = Math.Ceiling((double)people/(double)capacity);
            Console.WriteLine(coursesNeeded);
        }
    }
}