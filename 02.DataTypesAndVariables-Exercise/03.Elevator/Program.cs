﻿namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            //int courses = numberOfPeople / capacity;
            //if (numberOfPeople % capacity > 0)
            //{
            //    courses++;
            //}
            int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);

            Console.WriteLine(courses);
        }
    }
}