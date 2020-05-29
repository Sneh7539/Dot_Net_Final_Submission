using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The String In Infix Format : ");
            string infix = Console.ReadLine();
            string postfix;
            InfixToPostfix infixToPostfix = new InfixToPostfix();
            infixToPostfix.Converter(ref infix, out postfix);
            Console.WriteLine("String In Postfix Format : ");
            Console.WriteLine(postfix);
            Console.Read();
        }
    }
}
