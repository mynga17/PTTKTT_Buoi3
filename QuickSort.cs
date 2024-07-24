using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, 2, 4, 6, -1, 3};
            Quick_Sort(arr, 0, arr.Length - 1);
            //In mang da duoc sap xep
            foreach (int num in arr)
                Console.Write(num + " ");

            Console.ReadLine();
        }
        public static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                Quick_Sort(arr, left, pivotIndex - 1);
                Quick_Sort(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right]; //chon phan tu chot (pivot) la phan tu cuoi cung ben phai
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j) //Hon doi 2 phan tu trong mang
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
