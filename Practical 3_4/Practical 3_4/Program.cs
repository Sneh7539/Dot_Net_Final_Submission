using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting Decimal to Binary");
            DecimalToBinary(15);
            Console.WriteLine("\nConverting Binary to Decimal");
            BinaryToDecimal("1010");
            Console.WriteLine("\nConverting Decimal to Octal");
            DecimalToOctal(16);
            Console.WriteLine("\nConverting Decimal to Hexadecimal");
            DecimalToHex(100);
            Console.Read();
        }

        static void DecimalToBinary(int decimalNumber)
        {
            int number = decimalNumber;
            int[] binaryNumber = new int[20];
            int i;
            String output = "";
            for (i = 0; number > 0; i++)
            {
                binaryNumber[i] = number % 2;
                number /= 2;
            }

            for (i -= 1; i >= 0; i--)
            {
                output += binaryNumber[i].ToString();
            }
            Console.WriteLine("Decimal number: " + decimalNumber);
            Console.WriteLine("Binary number: " + output);
        }

        static void BinaryToDecimal(string stringBinaryNumber)
        {
            int Decimal = 0, i = 0, temp;
            int tempBinaryNumber = int.Parse(stringBinaryNumber);
            int binaryNumber = tempBinaryNumber;
            while (binaryNumber > 0)
            {
                temp = binaryNumber % 10;
                Decimal += (temp * (int)Math.Pow(2, i));
                i++;
                binaryNumber /= 10;
            }
            Console.WriteLine("Binary number: " + tempBinaryNumber);
            Console.WriteLine("Decimal number: " + Decimal);
        }

        static void DecimalToOctal(int decimalNumber)
        {
            int number = decimalNumber;
            int[] octalNumber = new int[20];
            int i;
            String output = "";
            for (i = 0; number > 0; i++)
            {
                octalNumber[i] = number % 8;
                number /= 8;
            }

            for (i -= 1; i >= 0; i--)
            {
                output += octalNumber[i].ToString();
            }
            Console.WriteLine("Decimal number: " + decimalNumber);
            Console.WriteLine("Octal number: " + output);
        }

        static void DecimalToHex(int decimalNumber)
        {
            int number = decimalNumber;
            int[] hexNumber = new int[20];
            int i;
            String output = "";
            for (i = 0; number > 0; i++)
            {
                hexNumber[i] = number % 16;
                number /= 16;
            }

            for (i -= 1; i >= 0; i--)
            {
                switch (hexNumber[i])
                {
                    case 10: output += "A"; break;
                    case 11: output += "B"; break;
                    case 12: output += "C"; break;
                    case 13: output += "D"; break;
                    case 14: output += "E"; break;
                    case 15: output += "F"; break;
                    default: output += hexNumber[i].ToString(); break;
                }
            }
            Console.WriteLine("Decimal number: " + decimalNumber);
            Console.WriteLine("Octal number: " + output);
        }
    }
}
