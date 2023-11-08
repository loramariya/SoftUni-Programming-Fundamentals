namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] arguments = input.Split();

                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                Product product = new Product(name, price, quantity);

                if (!products.ContainsKey(name))
                {
                    products.Add(product.Name, product);
                }
                else
                {
                    products[name].Update(product.Price, product.Quantity);
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.Value);
            }
        }
    }

    class Product
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void Update(decimal price, int quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public decimal GetTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {GetTotal():f2}";
        }
    }
}