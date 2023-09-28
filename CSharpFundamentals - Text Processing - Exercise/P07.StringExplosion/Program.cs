using System.Text;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int strength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    strength += int.Parse(input[i + 1].ToString());
                }
                else if (strength != 0)
                {
                    strength--;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}