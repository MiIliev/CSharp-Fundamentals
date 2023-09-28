namespace P04.Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}