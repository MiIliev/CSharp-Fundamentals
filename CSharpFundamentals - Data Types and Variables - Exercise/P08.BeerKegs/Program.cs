namespace P08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            double maximumVolume = double.MinValue;
            string modelBiggestKeg = null;
            for (int i = 0; i < kegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > maximumVolume)
                {
                    modelBiggestKeg = model;
                    maximumVolume = volume;
                }
            }
            Console.WriteLine(modelBiggestKeg);
        }
    }
}