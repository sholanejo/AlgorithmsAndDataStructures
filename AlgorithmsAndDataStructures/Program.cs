using System;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        public static int[] arrTest = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine(BinarySearch.BinSearch(arrTest, 1)); 

            Console.ReadKey();
        }
    }
}
