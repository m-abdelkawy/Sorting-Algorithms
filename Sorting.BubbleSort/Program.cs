using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.BubbleSort
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
            BubbleSortImproved(arr);
            PrintArray(arr);
            Console.ReadLine();

        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool SwapModified(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return true;
        }
        public static void BubbleSort1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void BubbleSort2(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
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

        //Improvement in Bubble Sorting - Break at number of swaps == 0
        public static void BubbleSortImproved(int[] arr)
        {
            int nSwaps;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                nSwaps = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        if (SwapModified(ref arr[j], ref arr[j + 1]))
                        {
                            nSwaps++;
                        }
                    }
                }
                if (nSwaps == 0)
                {
                    return;
                }
            }
        }
    }
}
