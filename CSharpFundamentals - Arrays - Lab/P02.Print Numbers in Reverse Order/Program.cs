namespace P02.Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());                
            }
            Array.Reverse(numbers);
            string result = string.Join(' ', numbers);
            Console.WriteLine(result);
            

        }
    }
}