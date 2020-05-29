using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6
{
    class Program
    {
        private static string ZeroDisplay()
        {
            return "zero";
        }
        private static string SingleDigitNumber(string number)
        {
            switch (number)
            {
                case "0": return (ZeroDisplay());

                case "1": return "one";

                case "2": return "two";

                case "3": return "three";

                case "4": return "four";

                case "5": return "five";

                case "6": return "six";

                case "7": return "seven";

                case "8": return "eight";

                case "9": return "nine";

                default: return "not assign";
            }
        }

        private static string TwoDigitNumber(string number)
        {
            string output;
            if (number == "00")
                output = ZeroDisplay();
            else if (number[0] == '0')
            {
                output = SingleDigitNumber(number[1].ToString());
            }

            else if (number[0] == '1')
            {
                switch (number)
                {
                    case "10": output = "ten"; break;

                    case "11": output = "eleven"; break;

                    case "12": output = "twelve"; break;

                    case "13": output = "thirteen"; break;

                    case "14": output = "fourteen"; break;

                    case "15": output = "fifteen"; break;

                    case "16": output = "sixteen"; break;

                    case "17": output = "seventeen"; break;

                    case "18": output = "eighteen"; break;

                    case "19": output = "nineteen"; break;

                    case "20": output = "twenty"; break;

                    default: output = "not assigned"; break;
                }
            }

            else if (number[0] == '2')
            {
                output = "twenty " + SingleDigitNumber(number[1].ToString());
            }

            else if (number[0] == '3')
            {
                output = "thirty " + SingleDigitNumber(number[1].ToString());
            }

            else if (number[0] == '4')
            {
                output = "fourty " + SingleDigitNumber(number[1].ToString());
            }

            else if (number[0] == '5')
            {
                output = "fifty " + SingleDigitNumber(number[1].ToString());
            }

            else if (number[0] == '6')
            {
                output = "sixty " + SingleDigitNumber(number[1].ToString());
            }

            else if (number[0] == '7')
            {
                output = "seventy " + SingleDigitNumber(number[1].ToString());
            }

            else if (number[0] == '8')
            {
                output = "eighty " + SingleDigitNumber(number[1].ToString());
            }

            else if (number[0] == '9')
            {
                output = "ninety " + SingleDigitNumber(number[1].ToString());
            }

            else
            {
                output = "not assigned";
            }

            return output;
        }

        private static string ThreeDigitNumber(string number)
        {
            string output;
            if (number == "000")
                output = ZeroDisplay();
            else if (number[0] == '0' && number[1] == '0')
                output = SingleDigitNumber(number[2].ToString());
            else if (number[0] == '0')
            {
                string num1 = number.Substring(1, 2);
                output = TwoDigitNumber(num1);
            }
            else
            {
                string num1 = number.Substring(1, 2);
                output = SingleDigitNumber(number[0].ToString()) + " hundred " + TwoDigitNumber(num1);
            }

            return output;
        }

        private static string FourDigitNumber(string number)
        {
            string output;
            string num1;
            if (number == "0000")
                output = ZeroDisplay();
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0')
                output = SingleDigitNumber(number[3].ToString());
            else if (number[0] == '0' && number[1] == '0')
            {
                num1 = number.Substring(2, 2);
                output = TwoDigitNumber(num1);
            }
            else if (number[0] == '0')
            {
                num1 = number.Substring(1, 3);
                output = ThreeDigitNumber(num1);
            }
            else
            {
                num1 = number.Substring(1, 3);
                output = SingleDigitNumber(number[0].ToString()) + " thousand " + ThreeDigitNumber(num1);
            }
            return output;
        }

        private static string FiveDigitNumber(string number)
        {
            string output;
            string num1;
            if (number == "00000")
                output = ZeroDisplay();
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0')
                output = SingleDigitNumber(number[4].ToString());
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0')
            {
                num1 = number.Substring(3, 2);
                output = TwoDigitNumber(num1.ToString());
            }
            else if (number[0] == '0' && number[1] == '0')
            {
                num1 = number.Substring(2, 3);
                output = ThreeDigitNumber(num1.ToString());
            }
            else if (number[0] == '0')
            {
                num1 = number.Substring(1, 4);
                output = FourDigitNumber(num1.ToString());
            }
            else
            {
                num1 = number.Substring(2, 3);
                string num2 = number.Substring(0, 2);
                output = TwoDigitNumber(num2) + " thousand " + ThreeDigitNumber(num1);
            }
            return output;
        }

        private static string SixDigitNumber(string number)
        {
            string output, num1;
            if (number == "000000")
                output = ZeroDisplay();
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0')
                output = SingleDigitNumber(number[5].ToString());
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0')
            {
                num1 = number.Substring(4, 2);
                output = TwoDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0')
            {
                num1 = number.Substring(3, 3);
                output = ThreeDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0')
            {
                num1 = number.Substring(2, 4);
                output = FourDigitNumber(num1);
            }
            else if (number[0] == '0')
            {
                num1 = number.Substring(1, 5);
                output = FiveDigitNumber(num1);
            }
            else
            {
                num1 = number.Substring(1, 5);
                output = SingleDigitNumber(number[0].ToString()) + " lakh " + FiveDigitNumber(num1);
            }
            return output;
        }

        private static string SevenDigitNumber(string number)
        {
            string output, num1;

            if (number == "0000000")
                output = ZeroDisplay();
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0' && number[5] == '0')
                output = SingleDigitNumber(number[6].ToString());
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0')
            {
                num1 = number.Substring(5, 2);
                output = TwoDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0')
            {
                num1 = number.Substring(4, 3);
                output = ThreeDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0')
            {
                num1 = number.Substring(3, 4);
                output = FourDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0')
            {
                num1 = number.Substring(2, 5);
                output = FiveDigitNumber(num1);
            }
            else if (number[0] == '0')
            {
                num1 = number.Substring(1, 6);
                output = SixDigitNumber(num1);
            }
            else
            {
                num1 = number.Substring(0, 2);
                string num2 = number.Substring(2, 5);
                output = TwoDigitNumber(num1) + " lakh " + FiveDigitNumber(num2);
            }
            return output;
        }

        private static string EightDigitNumber(string number)
        {
            string output, num1;

            if (number == "00000000")
                output = ZeroDisplay();
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0' && number[5] == '0' && number[6] == '0')
                output = SingleDigitNumber(number[7].ToString());
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0' && number[5] == '0')
            {
                num1 = number.Substring(6, 2);
                output = TwoDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0')
            {
                num1 = number.Substring(5, 3);
                output = ThreeDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0')
            {
                num1 = number.Substring(4, 4);
                output = FourDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0')
            {
                num1 = number.Substring(3, 5);
                output = FiveDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0')
            {
                output = SixDigitNumber(number[6].ToString());
            }
            else if (number[0] == '0')
            {
                num1 = number.Substring(1, 7);
                output = SevenDigitNumber(num1.ToString());
            }
            else
            {
                num1 = number.Substring(1, 7);
                output = SingleDigitNumber(number[0].ToString()) + " crore " + SevenDigitNumber(num1);
            }

            return output;
        }

        private static string NineDigitNumber(string number)
        {
            string output, num1;

            if (number == "000000000")
                output = ZeroDisplay();
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0' && number[5] == '0' && number[6] == '0' && number[7] == '0')
                output = SingleDigitNumber(number[8].ToString());
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0' && number[5] == '0' && number[6] == '0')
            {
                num1 = number.Substring(7, 2);
                output = TwoDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0' && number[5] == '0')
            {
                num1 = number.Substring(6, 3);
                output = ThreeDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0' && number[4] == '0')
            {
                num1 = number.Substring(5, 4);
                output = FourDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0' && number[3] == '0')
            {
                num1 = number.Substring(4, 5);
                output = FiveDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0' && number[2] == '0')
            {
                num1 = number.Substring(3, 6);
                output = SixDigitNumber(num1);
            }
            else if (number[0] == '0' && number[1] == '0')
            {
                num1 = number.Substring(2, 7);
                output = SevenDigitNumber(num1);
            }
            else if (number[0] == '0')
            {
                num1 = number.Substring(1, 8);
                output = EightDigitNumber(num1);
            }
            else
            {
                num1 = number.Substring(0, 2);
                string num2 = number.Substring(2, 7);
                output = TwoDigitNumber(num1) + " crore " + SevenDigitNumber(num2);
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number");
            string number = Console.ReadLine();
            string output;
            int length = number.Length;
            switch (length)
            {
                case 1: output = SingleDigitNumber(number); break;
                case 2: output = TwoDigitNumber(number); break;
                case 3: output = ThreeDigitNumber(number); break;
                case 4: output = FourDigitNumber(number); break;
                case 5: output = FiveDigitNumber(number); break;
                case 6: output = SixDigitNumber(number); break;
                case 7: output = SevenDigitNumber(number); break;
                case 8: output = EightDigitNumber(number); break;
                case 9: output = NineDigitNumber(number); break;
                default: output = "not assigned"; break;
            }
            Console.WriteLine(output);
            Console.Read();
        }
    }
}
