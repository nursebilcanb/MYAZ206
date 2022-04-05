using Stack;
using System;

namespace StackConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var charset = new char[] { 'a', 'b', 'c', 'd', 'e' };
            var stack1 = new Stack<char>();
            var stack2 = new Stack<char>(StackType.LinkedList);

            foreach (var item in charset)
            {
                Console.WriteLine(item);
                stack1.Push(item);
                stack2.Push(item);
            }
            Console.WriteLine($"Stack1 Peek: {stack1.Peek()}");
            Console.WriteLine($"Stack2 Peek: {stack2.Peek()}");
            Console.WriteLine();
          
            Console.WriteLine($"Stack1 Count: {stack1.Count}");
            Console.WriteLine($"Stack2 Count: {stack2.Count}");
            Console.WriteLine();
            
            Console.WriteLine($"Stack1 Pop: {stack1.Pop()}");
            Console.WriteLine($"Stack2 Pop: {stack2.Pop()}");

            Console.ReadKey();
        }
    }
}
