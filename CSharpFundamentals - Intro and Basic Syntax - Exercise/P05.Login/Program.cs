namespace P05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = null;
            for (int i = username.Length-1; i >= 0; i--)
            {
                char letter = username[i];
                password = password + letter;
            }
            string passwordInput = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                if (passwordInput == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        passwordInput = Console.ReadLine();
                    }
                }
            }
        }
    }
}