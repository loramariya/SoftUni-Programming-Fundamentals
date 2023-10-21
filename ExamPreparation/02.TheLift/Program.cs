﻿namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int maxCapacity = 4;

            for (int i = 0; i < wagons.Length; i++)
            {
                int currentWagon = wagons[i];
                if (currentWagon < 4)
                {
                    int emptySeats = 4 - wagons[i];
                    people -= emptySeats;
                    if (people < 0)
                    {
                        wagons[i] =  4 - Math.Abs(people);
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", wagons));
                        return;
                    }
                    wagons[i] = 4;
                }
            }

            if (people != 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
