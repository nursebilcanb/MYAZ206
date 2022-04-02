using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var definition = "2*(4+3)";

            Stack<char> stack = new Stack<char>();
            List<char> postFix = new List<char>();

            string postFixString = null;

            foreach (var item in definition)
            {
                if (item.Equals('+') || item.Equals('-') || item.Equals('*') || item.Equals('/'))
                {
                    stack.Push(item);
                }
                else if (char.IsDigit(item))
                {
                    postFix.Add(item);
                }
            }

            foreach (var item in postFix)
            {
                postFixString += item;
            }

            var n = stack.Count;
            for (int i = 0; i < n; i++)
            {
                postFixString += stack.Pop();
            }
            stack.Clear();
            int index = 0;
            n = postFixString.Length;

            do
            {
                if (char.IsDigit(postFixString[index]))
                {
                    stack.Push(postFixString[index]);
                }
                else
                {
                    var a = int.Parse(stack.Pop().ToString());
                    var b = int.Parse(stack.Pop().ToString());

                    int result;

                    switch (postFixString[index])
                    {
                        case '+':
                            result = a + b;
                            stack.Push((char)result);
                            break;
                        case '-':
                            result = a - b;
                            stack.Push((char)result);
                            break;
                        case '*':
                            result = a * b;
                            stack.Push((char)result);
                            break;
                        case '/':
                            result = a / b;
                            stack.Push((char)result);
                            break;
                    }

                    stack.Push((char)result);
                }

            }
            index = index +  1;
            while (stack.Count !=1);

            //foreach (var item in postFixString)
            //{
            //    stack.Push(item);
            //    if (item.Equals('+') || item.Equals('-') || item.Equals('*') || item.Equals('/'))
            //    {
            //        stack.Pop();
            //        var x = stack.Pop();
            //        var y = stack.Pop();
            //        Console.WriteLine($"{x} {item} {y}");
            //    }
            //}

        }
    }
}
