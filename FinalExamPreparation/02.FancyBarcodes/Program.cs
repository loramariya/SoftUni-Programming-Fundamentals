using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@#+(?<barcode>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})@#+";

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                Regex regex = new Regex(pattern);
                Match match = regex.Match(barcode);

                if (match.Success)
                {
                    char[] split = match.Groups[1].Value.ToCharArray();
                    List<char> digits = new List<char>();

                    foreach (char c in split)
                    {
                        if (char.IsDigit(c))
                        {
                            digits.Add(c);
                        }
                    }
                    if (digits.Count == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", digits)}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
            }
        }
    }
}

/*
3
@#FreshFisH@#
@###Brea0D@###
@##Che4s6E@##

6
@###Val1d1teM@###
@#ValidIteM@#
##InvaliDiteM##
@InvalidIteM@
@#Invalid_IteM@#
@#ValiditeM@#
*/