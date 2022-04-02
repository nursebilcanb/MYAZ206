using System;
using ValueAndReferenceTypes;

namespace RefAndOutConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var refAndValue = new ReferenceType();
            int a = 23, b = 55;

            Console.WriteLine($"a:{a} b:{b}");
            refAndValue.SwapByRef(ref a, ref b);
            Console.WriteLine($"a:{a} b:{b}");

            Console.WriteLine(new string('-', 50));

            refAndValue.CheckOutKeyWordByValue(b);
            Console.WriteLine(b);
            refAndValue.CheckOutKeyWordByRef(out b);
            Console.WriteLine(b);

            Console.WriteLine(new string('-', 50));

            var arr = new int[] { 1, 2, 3 };
            arr.SetValue(10, 0);
            Console.WriteLine(arr.GetValue(0));
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
