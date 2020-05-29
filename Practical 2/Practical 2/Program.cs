using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userCountry;
            while (true)
            {
                Console.WriteLine("Please Enter Your Good Name : ");
                userName = Console.ReadLine();
                Console.WriteLine("From Which Country You Belong");
                userCountry = Console.ReadLine();

                if (Regex.IsMatch(userName, @"^[a-zA-Z]+$") && Regex.IsMatch(userCountry, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("\nHello " + userName + " from country " + userCountry + "!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nOOPS! There Is Invalid Name or Country Name...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.ReadLine();
        }
    }
}
