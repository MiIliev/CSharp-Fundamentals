namespace P09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));

            }
            else if (command == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (command == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string a, string b)
        {

            int comparison = a.CompareTo(b);
            if (comparison > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}