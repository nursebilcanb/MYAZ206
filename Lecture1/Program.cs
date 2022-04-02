using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 255;
            Console.WriteLine($"{byte.MinValue} - " +
                $"{byte.MaxValue}");
            Console.WriteLine($"{sbyte.MinValue} - " +
                $"{sbyte.MaxValue}");

            Console.WriteLine($"{int.MinValue} - " +
                $"{int.MaxValue}");
            Console.WriteLine($"{uint.MinValue} - " +
              $"{uint.MaxValue}");
            Console.ReadLine(); ;
        }
    }
}
