namespace _06.VehicleCatalogue
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string input;
            List<Vehicle> vehicles = new List<Vehicle>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                string horsepower = arguments[3];

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);

                vehicles.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.Find(v => v.Model == input));
            }


            decimal averageHP = vehicles
                .Where(vehicle => vehicle.Type == "Car")
                .Select(vehicle => vehicle.Horsepower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = vehicles
                .Where(vehicle => vehicle.Type == "Truck")
                .Select(vehicle => vehicle.Horsepower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
        }
    }

}

enum Type
{
    Car,
    Truck
}

class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal Horsepower { get; set; }

    public Vehicle(string type, string model, string color, string horsepower)
    {
        Type = type == "car" ? "Car" : "Truck";
        Model = model;
        Color = color;
        Horsepower = decimal.Parse(horsepower);
    }

    public override string ToString()
    {
        return $"Type: {Type}\n" +
               $"Model: {Model}\n" +
               $"Color: {Color}\n" +
               $"Horsepower: {Horsepower}";
    }
}