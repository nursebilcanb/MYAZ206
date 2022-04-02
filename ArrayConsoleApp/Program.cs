using System;

namespace ArrayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var _arr = new DataStructures.Arrays.Array.Array();
            _arr.SetValue(1, 0);
            _arr.SetValue(5, 1);
            _arr.SetValue(8, 2);
            _arr.SetValue(7, 3);
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }

            var arr = System.Array.CreateInstance(typeof(int), 4);

            arr.SetValue(23, 0);
            arr.SetValue(44, 1);
            arr.SetValue(61, 2);
            arr.SetValue(55, 3);

            // 0 : 23 1:44 2:61 3:55

            Console.WriteLine(arr.GetValue(0));
            try
            {
                Console.WriteLine(arr.GetValue(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            var _array = new DataStructures.Arrays.Array.Array(1, 2, 3);
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
