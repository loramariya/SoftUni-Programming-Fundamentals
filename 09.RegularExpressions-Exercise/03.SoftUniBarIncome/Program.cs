using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Order
    {
        public string Customer { get; set; }
        public string Product { get; set; }
        public uint Count { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Count * Price;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalIncome = 0;

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                string pattern = @"\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+(?:\.\d+)?)\$";

                if (Regex.IsMatch(input, pattern) == false)
                {
                    continue;
                }

                Match match = Regex.Match(input, pattern);

                Order order = new Order();
                order.Customer = match.Groups[1].Value;
                order.Product = match.Groups[2].Value;
                order.Count = uint.Parse(match.Groups[3].Value);
                order.Price = decimal.Parse(match.Groups[4].Value);

                totalIncome += order.TotalPrice;
                Console.WriteLine($"{order.Customer}: {order.Product} - {order.TotalPrice:F2}");
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}