using _07.VehicleCatalogue;
using System;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string input = Console.ReadLine();


            while (input != "end")
            {
                string[] tokens = input.Split('/');

                string  type = tokens[0];
                string  brand = tokens[1];
                string  model = tokens[2];
                int value = int.Parse(tokens[3]);

                if (type == "Car")
                {
                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = value;

                    catalog.Cars.Add(car);
                }
                
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = value;

                    catalog.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Cars:");
            foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");
            foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}

