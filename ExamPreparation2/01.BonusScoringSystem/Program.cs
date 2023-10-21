namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            decimal maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < students; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                decimal bonus = Math.Ceiling((decimal)attendances / lectures * (5 + additionalBonus));

                if (bonus > maxBonus)
                {
                    maxBonus = bonus;
                    maxAttendance = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }

    }
}

