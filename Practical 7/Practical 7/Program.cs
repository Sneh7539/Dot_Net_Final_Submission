using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Practical_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Enter Value In INR :");
            decimal rupees = decimal.Parse(Console.ReadLine());
            decimal euro = 0.012M * rupees;
            decimal franc = 0.013M * rupees;
            decimal dollar = 74.19M * rupees;
            Console.WriteLine($"{rupees.ToString("C", CultureInfo.CreateSpecificCulture("hi-IN"))} = {euro.ToString("C", CultureInfo.CreateSpecificCulture("en-GB"))}");
            Console.WriteLine($"{rupees.ToString("C", CultureInfo.CreateSpecificCulture("hi-IN"))} = {franc.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"))}");
            Console.WriteLine($"{rupees.ToString("C", CultureInfo.CreateSpecificCulture("hi-IN"))} = {dollar.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.ReadLine();
        }
    }
}
