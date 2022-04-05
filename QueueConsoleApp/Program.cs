using Queue;
using System;

namespace QueueConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 10, 20, 30 };
            var q1 = new Queue<int>();
            var q2 = new Queue<int>(QueueType.LinkedList);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                q1.EnQueue(number);
                q2.EnQueue(number);
            }
            Console.WriteLine($"q1 count: {q1.Count}");
            Console.WriteLine($"q2 count: {q2.Count}");

            Console.WriteLine($"{q1.DeQueue()} has been removed from q1");
            Console.WriteLine($"{q2.DeQueue()} has been removed from q2");

            Console.WriteLine($"q1 peek: {q1.Peek()}");
            Console.WriteLine($"q2 peek: {q2.Peek()}");

            Console.WriteLine($"q1 count: {q1.Count}");
            Console.WriteLine($"q2 count: {q2.Count}");

            Console.ReadKey();
        }
    }
}
