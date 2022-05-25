using Microsoft.Graph;
using System;

namespace SortingAlgorithm
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] array)
            where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                var minValue = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[minIndex];
                    }
                }
                //Swap
                Sorting.Swap<T>(array, i, minIndex);
            }
        }
        //public static void Sort<T>(T[] array,
        //    Shared.SortDirection sortDirection = new Shared.SortDirection.Asceding)
        //{
        //    var comparer = new Shared.CustomComparer<T>(
        //        sortDirection, Comparer<T>.Default);
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            if (comparer.Compare(array[j], array[i]) >= 0)
        //                continue;
        //            Sorting.Swap<T>(array, i, j);
        //        }
        //    }
        //}

    }
}
