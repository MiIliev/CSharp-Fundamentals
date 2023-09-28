namespace P06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> playerTwoCards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            (playerOneCards, playerTwoCards) = PlayTheGame(playerOneCards, playerTwoCards);
            if (playerOneCards.Count > playerTwoCards.Count)
            {
                Console.WriteLine($"First player wins! Sum: {playerOneCards.Sum()}");
            }
            else if (playerTwoCards.Count > playerOneCards.Count)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwoCards.Sum()}");
            }

        }

        static (List<int> playerOneRemainingCards, List<int> playerTwoRemainingCards) PlayTheGame (List<int> playerOneCards, List<int> playerTwoCards)
        {
            while (playerOneCards.Count > 0 && playerTwoCards.Count > 0)
            {
                int firstPlayerCard = playerOneCards[0];
                int secondPlayerCard = playerTwoCards[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    playerOneCards.Add(firstPlayerCard);
                    playerOneCards.Add(secondPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    playerTwoCards.Add(secondPlayerCard);
                    playerTwoCards.Add(firstPlayerCard);
                }

                playerOneCards.RemoveAt(0);
                playerTwoCards.RemoveAt(0);
            }
            return (playerOneCards, playerTwoCards);

        }
    }
}