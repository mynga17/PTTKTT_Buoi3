using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    class BinarySearch_KhongDeQui
    {
        public static void Main(string[] args)
        {
            int n, first, middle, last, key;
            int[] a;
            bool found = false;
            Console.WriteLine("Nhap so phan tu cua mang:");
            n = int.Parse(Console.ReadLine());
            //Khởi tạo mảng
            a = new int[n];
            //Nhập dữ liệu cho từng phần tử mảng, chỉ số mảng bắt đầu từ 0
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Gia tri can tim trong mang:");
            key = int.Parse(Console.ReadLine());
            first = 0;
            last = n - 1;
            while (first <= last)
            {
                middle = (first + last) / 2;

                if (a[middle] < key)
                    first = middle + 1;
                else if (a[middle] == key)
                {
                    Console.WriteLine("Tim gia tri {0} o vi tri {1} trong mang", key, (middle));
                    found = true;
                    break;
                }
                else
                    last = middle - 1;
            }
            if (found == false)
                Console.WriteLine("Khong tim thay gia tri");

            Console.ReadLine();
        }
    }
}
