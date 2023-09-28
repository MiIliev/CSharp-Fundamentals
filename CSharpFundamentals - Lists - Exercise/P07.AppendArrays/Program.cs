using System.Reflection;

string[] input = Console.ReadLine().Split("|").ToArray();
Array.Reverse(input);
List<int> result = new List<int>();
for (int i = 0; i < input.Length; i++)
{
    string[] elements = input[i].Split(" ");
    foreach(string number in elements)
    {
        bool isNumber = int.TryParse(number, out int parsedNumber);
        if(isNumber)
        {
            result.Add(parsedNumber);
        }
    }
}
Console.WriteLine(string.Join(" ", result));
