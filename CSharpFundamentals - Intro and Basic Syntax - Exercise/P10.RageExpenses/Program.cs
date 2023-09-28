namespace P10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            int trashedHeadsets = lostGameCount / 2;
            int trashedMice = lostGameCount / 3;
            int trashedKeyboards = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboards++;
                }
            }
            int trashedDisplays = trashedKeyboards / 2;

            float expenses =
                headsetPrice * trashedHeadsets +
                mousePrice * trashedMice +
                keyboardPrice * trashedKeyboards +
                displayPrice * trashedDisplays;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}