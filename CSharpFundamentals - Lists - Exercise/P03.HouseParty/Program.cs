namespace P03.HouseParty
{
    internal class Program
    {
        static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> people = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string input = Console.ReadLine();
                string[] token = input.Split();
                if (token[2] != "not") // {name} is going!
                {
                    bool personIsOnTheList = false;
                    foreach (string person in people)
                    {                        
                        if (person == token[0])
                        {
                            personIsOnTheList = true;
                            Console.WriteLine($"{token[0]} is already in the list!");
                            break;
                        }
                    }
                    if (!personIsOnTheList)
                    {
                        people.Add(token[0]);
                    }
                }
                else // {name} is NOT going!
                {
                    bool personIsOnTheList = false;
                    foreach (string person in people)
                    {
                        if (person == token[0])
                        {
                            personIsOnTheList = true;
                            people.Remove(person);
                            break;
                        }
                    }
                    if (!personIsOnTheList)
                    {
                        Console.WriteLine($"{token[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", people));
        }
    }
}