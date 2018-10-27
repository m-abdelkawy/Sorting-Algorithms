using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of Array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number of index {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array Unsorted: ");
            PrintArr(arr);
            Console.WriteLine();
            Console.WriteLine("/*-----------------------------------*/");

            Console.WriteLine("Array Sorted: ");
            SelectionSort(arr);

            Console.ReadLine();
            
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
            PrintArr(arr);
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
        }
    }
}
