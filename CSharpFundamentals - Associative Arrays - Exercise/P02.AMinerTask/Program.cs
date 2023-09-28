using System.Linq;

namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourceInput = null;
            var resourceManager = new Dictionary<string, int>();

            while ((resourceInput = Console.ReadLine()) != "stop")
            {
                int quantityInput = int.Parse(Console.ReadLine());
                if (!resourceManager.ContainsKey(resourceInput))
                {
                    resourceManager.Add(resourceInput, quantityInput);
                }
                else
                {
                    resourceManager[resourceInput] += quantityInput;
                }
            }
            foreach (var resource in resourceManager)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }

        }
    }
}