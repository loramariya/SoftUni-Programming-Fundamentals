using System.Reflection.Emit;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;

            price = GetPrice(product, price);
            PrintPrice(price, quantity);
        }

        private static double GetPrice(string product, double price)
        {
            switch (product)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2.0;
                    break;

            }

            return price;
        }

        static void PrintPrice (double price, int quantity)
        {
            double finalPrice = price * quantity;
            Console.WriteLine($"{finalPrice:f2}");

        }
    }
}