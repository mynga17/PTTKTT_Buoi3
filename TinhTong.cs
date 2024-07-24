using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    class TinhTong
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0;

            Console.Write("Nhap so luong phan tu can tinh tong vao mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang: \n", n);
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.Write("Tong cac phan tu trong mang la: {0}", sum);
            Console.ReadKey();
        }
    }
}
