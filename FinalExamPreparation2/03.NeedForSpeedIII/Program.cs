namespace _03.NeedForSpeedIII
{
    class Car
    {
        public Car(string type, int mileage, int fuel)
        {
            Type = type;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string Type { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] car = Console.ReadLine().Split("|").ToArray();

                string carType = car[0];
                int milage = int.Parse(car[1]);
                int fuel = int.Parse(car[2]);

                Car currentCar = new Car(carType, milage, fuel);
                cars.Add(currentCar);
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] tokens = input.Split(" : ");
                string command = tokens[0];
                string carType = tokens[1];

                Car car = cars.FirstOrDefault(c => c.Type == carType);

                switch (command)
                {
                    case "Drive":
                        int distance = int.Parse(tokens[2]);
                        int fuelNeeded = int.Parse(tokens[3]);

                        if (car != null)
                        {
                            if (car.Fuel > fuelNeeded)
                            {
                                car.Mileage += distance;
                                car.Fuel -= fuelNeeded;
                                Console.WriteLine($"{car.Type} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                            }
                            else
                            {   
                                Console.WriteLine("Not enough fuel to make that ride");
                            }

                            if (car.Mileage >= 100000)
                            {
                                cars.Remove(car);
                                Console.WriteLine($"Time to sell the {car.Type}!");
                            }
                        }
                        break;

                    case "Refuel":
                        int fuel = int.Parse(tokens[2]);

                        if (car != null)
                        {
                            int fuelRefiled = Math.Min(fuel, 75 - car.Fuel);

                            car.Fuel += fuelRefiled;

                            Console.WriteLine($"{car.Type} refueled with {fuelRefiled} liters");
                        }
                        break;
                    case "Revert":
                        int kilometers = int.Parse(tokens[2]);
                        if (car != null)
                        {
                            car.Mileage -= kilometers;

                            if (car.Mileage < 10000)
                            {
                                car.Mileage = 10000;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"{car.Type} mileage decreased by {kilometers} kilometers");
                            }
                        }
                        break;
                }
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Type} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }
}

/*
3 
Audi A6|38000|62 
Mercedes CLS|11000|35 
Volkswagen Passat CC|45678|5 
Drive : Audi A6 : 543 : 47 
Drive : Mercedes CLS : 94 : 11 
Drive : Volkswagen Passat CC : 69 : 8 
Refuel : Audi A6 : 50 
Revert : Mercedes CLS : 500 
Revert : Audi A6 : 30000 
Stop
 */
