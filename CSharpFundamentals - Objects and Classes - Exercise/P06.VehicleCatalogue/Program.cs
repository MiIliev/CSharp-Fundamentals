using System.Runtime.CompilerServices;

namespace P06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            List<Vehicle> vehicles = new List<Vehicle>();
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> inputList = input
                    .Split(" ")
                    .ToList();
                string type = inputList[0];
                string name = inputList[1];
                string color = inputList[2];
                int horsepower = int.Parse(inputList[3]);
                
                Vehicle newEntry = new Vehicle(type, name, color, horsepower);
                vehicles.Add(newEntry);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {

                Vehicle searchedVehicle = vehicles.First(vehicle => vehicle.Name.Equals(input));
                searchedVehicle.PrintDetails();
            }

            List<Vehicle> cars = vehicles.Where(vehicle => vehicle.Type.Equals("car")).ToList();
            List<Vehicle> trucks = vehicles.Where(vehicle => vehicle.Type.Equals("truck")).ToList();
            double carsAverageHp = cars.Any() ? cars.Average(car => car.Horsepower) : 0.0;
            double trucksAverageHp = trucks.Any() ? trucks.Average(truck => truck.Horsepower) : 0.0;
            Console.WriteLine($"Cars have average horsepower of: {carsAverageHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHp:f2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string name, string color, int horsepower)
        {
            Type = type;
            Name = name;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Type: {char.ToUpper(Type[0])}{Type.Substring(1)}\n" +
                $"Model: {char.ToUpper(Name[0])}{Name.Substring(1)}\n" +
                $"Color: {Color}\n" +
                $"Horsepower: {Horsepower}");
        }
    }

}