namespace P07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            List<Person> people = new List<Person>();
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> inputList = input
                    .Split(" ")
                    .ToList();
                string name = inputList[0];
                string id = inputList[1];
                int age = int.Parse(inputList[2]);

                Person person = people.FirstOrDefault(person => person.Id.Equals(id));

                if (person == null)
                {
                    people.Add(new Person(name, id, age));
                }
                else
                {
                    person.Age = age;
                    person.Name = name;
                }
            }
            people = people.OrderBy(person => person.Age).ToList();
            foreach(Person person in people) 
            {
                person.PrintPerson();
            }
            
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public void PrintPerson()
        {
            Console.WriteLine($"{Name} with ID: {Id} is {Age} years old.");
        }
    }
}