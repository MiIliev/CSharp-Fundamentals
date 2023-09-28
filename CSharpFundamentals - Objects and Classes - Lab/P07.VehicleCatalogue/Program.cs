namespace P07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            Catalogue catalogue = new Catalogue(cars, trucks);
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> inputList = input
                    .Split("/")
                    .ToList();

                string type = inputList[0];
                string brand = inputList[1];
                string model = inputList[2];
                string powerOrWeight = inputList[3];

                if (type == "Car")
                {
                   Car car = new Car(brand, model, powerOrWeight);
                   catalogue.AddCar(car);
                }
                else
                {
                    Truck truck = new Truck(brand, model, powerOrWeight);
                    catalogue.AddTruck(truck);
                }
            }
            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalogue.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, string horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    public class Catalogue
    {
        public Catalogue(List<Car> cars, List<Truck> trucks)
        {
            Cars = new List<Car> (cars);
            Trucks = new List<Truck> (trucks);
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void AddTruck(Truck truck)
        {
            Trucks.Add(truck);
        }
    }
}