namespace P01.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            while((input = Console.ReadLine()) != "end")
            {
                char[] inputArray = input.ToCharArray();
                Array.Reverse(inputArray);
                string reversedInput = new string(inputArray);
                Console.WriteLine($"{input} = {reversedInput.ToString()}");
            }
        }
    }
}