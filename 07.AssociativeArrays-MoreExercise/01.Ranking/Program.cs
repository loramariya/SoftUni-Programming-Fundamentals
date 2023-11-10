using System.Linq;

namespace _01.Ranking
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] arguments = input.Split(":");

                string contestName = arguments[0];
                string password = arguments[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, password);
                }
            }

            string input2;
            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] arguments = input2.Split("=>");

                string contestName = arguments[0];
                string password = arguments[1];
                string username = arguments[2];
                int points = int.Parse(arguments[3]);


                if (contests.ContainsKey(contestName) && contests[contestName] == password)
                {
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, new Dictionary<string, int>());
                        students[username].Add(contestName, points);
                    }
                    else
                    {
                        if (!students[username].ContainsKey(contestName))
                        {
                            students[username].Add(contestName, points);
                        }
                        else
                        {
                            if (students[username][contestName] < points)
                            {
                                students[username][contestName] = points;
                            }
                        }
                    }
                }

                arguments = input2.Split("=>");
            }

            string bestStudent = "";
                int topPoints = 0;

                foreach (var student in students)
                {
                    int totalpoints = 0;


                    foreach (var course in student.Value)
                    {
                        totalpoints += course.Value;
                    }

                    if (totalpoints > topPoints)
                    {
                        bestStudent = student.Key;
                        topPoints = totalpoints;
                    }
                }

                Console.WriteLine($"Best candidate is {bestStudent} with total {topPoints} points.");

                students = students
                    .OrderBy(x => x.Key)
                    .ToDictionary(k => k.Key, v => v.Value);

                Console.WriteLine("Ranking: ");

                foreach (var student in students)
                {
                    Console.WriteLine(student.Key);
                    foreach (var course in student.Value.OrderByDescending(v => v.Value))
                    {
                        Console.WriteLine($"#  {course.Key} -> {course.Value}");
                    }
                }
            
        }
    }
}
