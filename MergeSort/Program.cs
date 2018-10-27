using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 8, 3, 4, 6, 9 };
            int l = 1;
            int r = arr.Length;

            MergeSort(arr, l, r);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.ReadLine();
        }
        public static void MergeSort(int[] arr, int l, int r)
        {
            //Base case l == r
            if (l == r)
            {
                return;
            }
            //middle point m
            int m = l + (r - 1) / 2;

            //sorting first and second halves
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

            //merging sorted halves
            Merge(arr, l, m, r);
        }

        public static void Merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            //temp arrays
            int[] left = new int[n1];
            int[] right = new int[n2];

            //fill temp arrays with data
            for (i = 0; i < left.Length; i++)
            {
                left[i] = arr[i];
            }
            for (j = 0; j < right.Length; j++)
            {
                right[j] = arr[j];
            }
            i = 0;
            j = 0;
            //Comparison and merging
            k = l;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            //copy remaining elements if any
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
