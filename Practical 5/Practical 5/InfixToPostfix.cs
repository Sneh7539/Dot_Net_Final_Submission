using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5
{
    class InfixToPostfix
    {
        public string Converter(ref string infix, out string postfix)
        {
            postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if (isOperator(ch))
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(ch);
                    }
                    else
                    {
                        if (ch == '(')
                            stack.Push(ch);
                        else if (ch == ')')
                        {
                            while (stack.Peek() != '(')
                                postfix += stack.Pop();
                            stack.Pop();
                        }
                        else if (priority(ch) > priority(stack.Peek()))
                        {
                            stack.Push(ch);
                        }
                        else
                        {
                            while (stack.Count() != 0 && priority(ch) <= priority(stack.Peek()))
                                postfix += stack.Pop();
                            stack.Push(ch);
                        }
                    }
                }
                else
                    postfix += infix[i];
            }
            while (stack.Count > 0)
                postfix += stack.Pop();
            return postfix;
        }

        int priority(char ch)
        {
            switch (ch)
            {
                case '(':
                    return 0;

                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                default:
                    return -1;
            }
        }

        private bool isOperator(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '(':
                case ')':
                    return true;
                default:
                    return false;
            }
        }
    }
}
