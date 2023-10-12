namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(w, h);
            Console.WriteLine(area);
        }

        static double GetTriangleArea (double w, double h)
        {
            return w * h;
        }
    }
}