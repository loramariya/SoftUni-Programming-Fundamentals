namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] tokens = input.Split();

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item item = new Item
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    Quantity = itemQuantity,
                    PriceBox = itemQuantity * itemPrice,
                };

                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.PriceBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }

        }
    }
      

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }

    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}