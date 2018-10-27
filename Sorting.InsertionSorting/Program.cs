using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.InsertionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            //Fill Array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Arr[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("/*--------------------Unsorted Array--------------------*/");
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine("/*--------------------Sorted Array--------------------*/");
            InsertionSort(arr);
            PrintArray(arr);
            Console.ReadLine();
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
        }
    }
}
