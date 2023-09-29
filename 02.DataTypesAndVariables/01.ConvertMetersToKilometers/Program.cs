namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); int meters = int.Parse(Console.ReadLine());

            double km = (meters * 1.0) / 1000;

            Console.WriteLine($"{km:f2}");
        }
    }
}