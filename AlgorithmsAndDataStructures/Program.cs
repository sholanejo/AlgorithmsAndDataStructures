using System;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        public static int[] arrTest = new[] { 10, 2, 3, 4, 5, 6, 7, 8, 9, -1 };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("The smallest number is " + SelectionSort.SmallestNumber(arrTest));
            //Console.WriteLine("The smallest number is " + SelectionSort.SelectSort(arrTest));
            //Console.WriteLine(BinarySearch.BinSearch(arrTest, 1)); 
            //int[] arr = new int[10] { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
            //SelectionSort.Sort(arr);
            //Console.WriteLine("Sorted Values:");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            Console.WriteLine(Recursion.Recursive(4));

            Console.ReadKey();
        }
    }
}
