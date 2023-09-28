namespace CSharpFundamentals___Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int input = int.Parse(Console.ReadLine());
            if (input <= weekdays.Length && input >0)
            {
                Console.WriteLine(weekdays[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}