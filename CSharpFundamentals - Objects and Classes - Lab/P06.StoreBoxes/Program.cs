namespace P06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            List<Box> boxes = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> inputList = input
                    .Split(" ")
                    .ToList();

                Item item = new Item();
                int serialNumber = int.Parse(inputList[0]);
                item.Name = inputList[1];
                int quantity = int.Parse(inputList[2]);
                item.Price = decimal.Parse(inputList[3]);

                Box box = new Box(serialNumber, item, quantity);
                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(x => x.BoxPrice))
            {
                Console.WriteLine($"{box.SerialNumber}\n" +
                    $"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}\n" +
                    $"-- ${box.BoxPrice:f2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(int serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal BoxPrice
        {
            get => Item.Price * Quantity;
        }

    }
}