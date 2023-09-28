namespace P03.MagicCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> originalDeck = Console.ReadLine()
                .Split(":")
                .ToList();
            List<string> newDeck = new List<string>();
            string input = null;
            while ((input = Console.ReadLine()) != "Ready")
            {
                string[] command = input
                    .Split()
                    .ToArray();
                switch (command[0])
                {
                    case "Add":
                        newDeck = Add(originalDeck,newDeck, command[1]);
                        break;
                    case "Insert":
                        newDeck = Insert(originalDeck, newDeck, command[1], int.Parse(command[2]));
                        break;
                    case "Remove":
                        newDeck = Remove(newDeck, command[1]);
                        break;
                    case "Swap":
                        newDeck = Swap(newDeck, command[1], command[2]);
                        break;
                    case "Shuffle":
                        newDeck.Reverse();
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", newDeck));
        }
        private static List<string> Add(List<string> originalDeck, List<string>newDeck, string card)
        {
            if (originalDeck.Contains(card))
            {
                newDeck.Add(card);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
            return newDeck;
        }
        private static List<string> Insert(List<string> originalDeck, List<string>newDeck, string card, int index)
        {
            if (originalDeck.Contains(card) && index < newDeck.Count && index >= 0)
            {
                newDeck.Insert(index, card);
            }
            else
            {
                Console.WriteLine("Error!");
            }
            return newDeck;
        }
        private static List<string> Remove(List<string> newDeck, string card)
        {
            if (newDeck.Contains(card))
            {
                newDeck.Remove(card);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
            return newDeck;
        }
        private static List<string> Swap(List<string> newDeck, string firstCard, string secondCard)
        {
            List<string> cache = new List<string>(newDeck);
            int firstCardIndex = newDeck.IndexOf(firstCard);
            int secondCardIndex = newDeck.IndexOf(secondCard);
            newDeck[firstCardIndex] = cache[secondCardIndex];
            newDeck[secondCardIndex] = cache[firstCardIndex];
            return newDeck;
        }
    }
}