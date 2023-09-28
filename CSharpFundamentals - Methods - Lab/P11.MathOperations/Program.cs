namespace P11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(DoTheMath(firstNumber, action, secondNumber));
        }

        static double DoTheMath(int x, char action, int y)
        {
            switch (action)
            {
                case '/':
                    return x / y;
                    break;
                case '*':
                    return x * y;
                    break;
                case '+':
                    return x + y;
                    break;
                case '-':
                    return x - y;
                    break;
                default:
                    return 0;
            }
        }
    }
}