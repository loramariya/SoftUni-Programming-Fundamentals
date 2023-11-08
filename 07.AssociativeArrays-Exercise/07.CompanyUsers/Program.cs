
namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
           
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new Student(studentName));
                }

                students[studentName].Grades.Add(grade);
            }

            var fillteredStudents = students.Where(s => s.Value.Grades.Average() >= 4.50m);

            foreach (var studentPair in fillteredStudents)
            {
                Console.WriteLine($"{studentPair.Value}");
            }
        }
    }

    class Student
    {
        public string Name;
        public List<decimal> Grades;

        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }

        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():f2}";
        }
    }
}
