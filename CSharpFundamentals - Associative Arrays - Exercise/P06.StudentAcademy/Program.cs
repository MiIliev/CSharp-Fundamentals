namespace P06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var schoolBook = new Dictionary<string, List<double>>();
            string input = null;
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!schoolBook.ContainsKey(student))
                {
                    schoolBook.Add(student, new List<double> { grade });
                }
                else
                {
                    schoolBook[student].Add(grade);
                }
            }
            foreach (var student in schoolBook)
            {
                double averageGrade = student.Value.Average();
                if (averageGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }

        }
    }
}