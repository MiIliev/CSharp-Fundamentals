﻿
namespace P09.CharToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            string combined = $"{first}{second}{third}";

            Console.WriteLine(combined);
        }
    }
}