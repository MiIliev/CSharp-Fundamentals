using System.Text;

namespace P06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++) 
            {
                if (i == 0)
                {
                    sb.Append(input[i]);
                }
                else if (input[i] != input[i-1])
                {
                    sb.Append(input[i]);
                }            
            }
            Console.WriteLine(sb.ToString());

        }
    }
}