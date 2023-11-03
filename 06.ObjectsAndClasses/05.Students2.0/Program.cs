namespace _05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (input != "end")
            {
                string[] tokens = input.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                bool studentExists = false;

                foreach (var currentStudent in students)
                {
                    if (currentStudent.FirstName == student.FirstName
                        && currentStudent.LastName == student.LastName)
                    {
                        currentStudent.Age = student.Age;
                        currentStudent.HomeTown = student.HomeTown;
                        studentExists = true;
                    }
                }

                if (!studentExists)
                {
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            string cityFilter = Console.ReadLine();

            foreach (Student currentStudent in students)
            {
                if (currentStudent.HomeTown == cityFilter)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }

    public class Student
        {
            public Student(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }

        }
    }
