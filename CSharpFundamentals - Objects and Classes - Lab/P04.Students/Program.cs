﻿namespace P04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> inputToList = input
                    .Split(" ")
                    .ToList();
                string firstName = inputToList[0];
                string lastName = inputToList[1];
                int age = int.Parse(inputToList[2]);
                string homeTown = inputToList[3];

                students.Add(new Student(firstName,lastName,age,homeTown));
            }

            input = Console.ReadLine();
            foreach (Student student in students)
            {
                if (input == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}