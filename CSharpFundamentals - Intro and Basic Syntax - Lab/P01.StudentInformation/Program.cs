namespace CSharp___Intro_and_Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string averageGrade = Console.ReadLine();

            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade}");
        }
    }
}