namespace P01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int sumFirstAndSecond = firstNumber + secondNumber;
            decimal divideSumByThird = (decimal)(sumFirstAndSecond / thirdNumber);
            decimal multiplyDivisionByFourth = divideSumByThird * fourthNumber;
            Console.WriteLine(multiplyDivisionByFourth);
        }
    }
}