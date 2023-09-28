namespace P01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                FakeAdvertisement advertisement = NewAdvertisement();
                Console.WriteLine(advertisement.ToString());
            }
        }
        static FakeAdvertisement NewAdvertisement()
        {
            List<string> phrasesList = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };
            List<string> eventList = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authorsList = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena", "Katya",
                "Iva", "Annie",
                "Eva"
            };
            List<string> citiesList = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random random = new Random();

            int phraseIndex = random.Next(0, phrasesList.Count);
            int eventIndex = random.Next(0, eventList.Count);
            int authorsIndex = random.Next(0, authorsList.Count);
            int citiesIndex = random.Next(0, citiesList.Count);
            string phrase = phrasesList[phraseIndex];
            string @event = eventList[eventIndex];
            string authors = authorsList[authorsIndex];
            string city = citiesList[citiesIndex];
            return new FakeAdvertisement(phrase, @event, authors, city);
        }


    }

    public class FakeAdvertisement
    {
        public FakeAdvertisement(string phrases, string @event, string authors, string city)
        {
            Phrases = phrases;
            Event = @event;
            Authors = authors;
            City = city;
        }

        public string Phrases { get; set; }
        public string Event { get; set; }
        public string Authors { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Phrases} {Event} {Authors} - {City}.";
        }

    }
}
