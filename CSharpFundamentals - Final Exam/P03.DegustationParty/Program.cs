namespace P03.DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Guest> guests = new List<Guest>();
            string input = null;
            while ((input = Console.ReadLine()) != "Stop")
            {
                List<string> command = input
                    .Split("-")
                    .ToList();
                switch (command[0])
                {
                    case "Like":
                        guests = LikedMeal(command[1], command[2],guests);
                        break;
                    case "Dislike":
                        guests = DislikedMeal(command[1], command[2],guests);
                        break;
                }
            }
            int totalDislikedMeals = 0;
            foreach(Guest guest in guests)
            {
                Console.WriteLine($"{guest.Name}: {string.Join(", ",guest.LikedMeals)}");
                totalDislikedMeals += guest.DislikedMeals;
            }
            Console.WriteLine($"Unliked meals: {totalDislikedMeals}");
        }


        static List<Guest> LikedMeal(string nameOfGuest, string meal, List<Guest> guests)
        {
            Guest guest = guests.FirstOrDefault(guest => guest.Name == nameOfGuest);
            if(guest!=null)
            {
                if (!guest.LikedMeals.Contains(meal))
                {
                    guest.LikedMeals.Add(meal);
                }                
            }
            else
            {
                guest = new Guest(nameOfGuest);
                guest.LikedMeals.Add(meal);
                guests.Add(guest);                
            }
            return guests;
        }

        static List<Guest> DislikedMeal(string nameOfGuest, string meal, List<Guest> guests)
        {
            Guest guest = guests.FirstOrDefault(guest => guest.Name == nameOfGuest);
            if (guest != null)
            {
                if (guest.LikedMeals.Contains(meal))
                {
                    guest.LikedMeals.Remove(meal);
                    guest.DislikedMeals++;
                    Console.WriteLine($"{guest.Name} doesn't like the {meal}.");
                }
                else
                {
                    Console.WriteLine($"{guest.Name} doesn't have the {meal} in his/her collection.");
                }
            }
            else
            {
                Console.WriteLine($"{nameOfGuest} is not at the party.");
            }

                return guests;
        }
    }

    public class Guest
    {
        public Guest(string name)
        {
            Name = name;
            LikedMeals = new List<string>();
            DislikedMeals = 0;
        }

        public string Name { get; set; }
        public List<string> LikedMeals { get; set; }
        public int DislikedMeals { get; set; }
    }
}