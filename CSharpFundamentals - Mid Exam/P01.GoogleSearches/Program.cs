namespace P01.GoogleSearches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float income = float.Parse(Console.ReadLine());
            int numberOfUsers = int.Parse(Console.ReadLine());
            float totalMoney = 0;

            for (int i = 1; i <= numberOfUsers; i++)
            {
                float earnedMoney = 0;
                float searchesCount = float.Parse(Console.ReadLine());
                if (searchesCount == 1 || searchesCount <= 0)
                {
                    continue;
                }
                earnedMoney = income * searchesCount;
                if (i % 3 == 0)
                {
                    earnedMoney *= 3;
                }
                if (searchesCount > 5)
                {
                    earnedMoney *= 2;
                }                
                totalMoney += earnedMoney;
            }

            Console.WriteLine($"Total money earned: {totalMoney:f2}");
        }
    }
}