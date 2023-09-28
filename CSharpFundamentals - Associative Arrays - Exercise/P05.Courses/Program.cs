namespace P05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string input = null;
            while((input = Console.ReadLine()) != "end") 
            {
                string[] inputToArray = input
                    .Split(" : ")
                    .ToArray();
                string course = inputToArray[0];
                string student = inputToArray[1];
            if (courses.ContainsKey(course))
                {
                    courses[course].Add(student);
                }
                else
                {
                    courses.Add(course, new List<string> { student });
                }
            }
            foreach(var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}