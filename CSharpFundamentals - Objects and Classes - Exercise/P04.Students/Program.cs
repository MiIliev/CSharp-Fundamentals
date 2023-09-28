namespace P04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            int countStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countStudents; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ")
                    .ToList();
                string firstName = input[0];
                string lastName = input[1];
                float grade = float.Parse(input[2]);

                Student student = new Student(firstName, lastName, grade);
                studentsList.Add(student);
            }
            studentsList = studentsList.OrderByDescending(x => x.Grade).ToList();
            foreach (Student student in studentsList)
            {
                Console.WriteLine(student.PrintStudent());
            }

        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public string PrintStudent ()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    
    }
}