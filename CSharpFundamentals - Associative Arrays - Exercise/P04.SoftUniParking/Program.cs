namespace P04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new Dictionary<string, string>();
            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();
                string command = input[0];
                string name = input[1];
                switch (command)
                {
                    case "register":
                        string licensePlate = input[2];
                        if (cars.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {cars[name]}");
                        }
                        else
                        {
                            cars.Add(name, licensePlate);
                            Console.WriteLine($"{name} registered {licensePlate} successfully");
                        }
                        break;
                    case "unregister":
                        if(cars.ContainsKey(name))
                        {
                            cars.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;
                }
            }
            foreach( var car in cars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}