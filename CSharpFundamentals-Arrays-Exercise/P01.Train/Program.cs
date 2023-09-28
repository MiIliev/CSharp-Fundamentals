using System.Threading.Tasks.Dataflow;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peoplePerWagon = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                peoplePerWagon[i] = int.Parse(Console.ReadLine());
            }

            int allPeople = 0;
            foreach(int people in peoplePerWagon)
            {
                allPeople += people;
            }
            Console.WriteLine(string.Join(" ", peoplePerWagon));
            Console.WriteLine(allPeople);
        }
    }
}