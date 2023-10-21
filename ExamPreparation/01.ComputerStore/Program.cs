namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double priceWithoutTaxes = 0;
            double taxes = 0;
            

            while (input != "special" && input != "regular")
            {
                double partsPrice = double.Parse(input);

                if (partsPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceWithoutTaxes += partsPrice;
                    taxes += partsPrice * 0.2;
                }

                input = Console.ReadLine();
            }
            double totalPrice = priceWithoutTaxes + taxes;

            if (input == "special")
            {
                totalPrice = totalPrice * 0.9;
            }
            
            
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
