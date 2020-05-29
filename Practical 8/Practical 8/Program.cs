using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1. Celcius to Fenrenheit\n2. Fehrenheit to Celcius");
            int choice = int.Parse(Console.ReadLine());

            float celcius, fahrenheit;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter amouunt of temperature in Celcius");
                    celcius = float.Parse(Console.ReadLine());
                    fahrenheit = celcius * 9 / 5 + 32;
                    Console.WriteLine("Celcius : " + celcius + "\nFahrenheit : " + fahrenheit);
                    break;

                case 2:
                    Console.WriteLine("Enter amouunt of temperature in Fahrenheit");
                    fahrenheit = float.Parse(Console.ReadLine());
                    celcius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Fahrenheit : " + fahrenheit + "\nCelcius : " + celcius);
                    break;


                default:
                    Console.WriteLine("Sorry! Wrong Choice.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
