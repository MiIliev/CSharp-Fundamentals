namespace P05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int bomb = bombList[0];
            int power = bombList[1];
            DetonateBomb(numbers, bomb, power);
            Console.WriteLine(numbers.Sum());
        }

        static void DetonateBomb(List<int> numbers, int bomb, int power)
        {
            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);
                int rangeLeft = Math.Max(bombIndex - power, 0);
                int rangeRight= Math.Min(bombIndex + power, numbers.Count - 1);
                int rangeLength = rangeRight - rangeLeft + 1; 
                numbers.RemoveRange(rangeLeft, rangeLength);
            }
        }
    }
}