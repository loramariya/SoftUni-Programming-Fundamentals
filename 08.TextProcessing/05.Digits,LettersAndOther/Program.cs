namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(input.Where(x=> char.IsDigit(x)).ToArray());
            Console.WriteLine(input.Where(x=> char.IsLetter(x)).ToArray());
            Console.WriteLine(input.Where(x=> !char.IsDigit(x) && !char.IsLetter(x)).ToArray());
        }
    }
}