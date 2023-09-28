namespace P06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            int sum = 0;
            for (int i = 0; i < numberInput.Length; i++)
            {
                char digitChar = numberInput[i];
                int digitInt = (int)Char.GetNumericValue(digitChar);
                int digitFrac = 1;
                for (int l = digitInt; l > 0; l--)
                {
                    digitFrac *= l;
                }
                sum += digitFrac;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}