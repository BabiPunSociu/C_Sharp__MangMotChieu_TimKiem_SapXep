using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mang1Chieu arr = new Mang1Chieu();
            arr.nhapMang();

            Console.WriteLine();
            Console.Write("Mang da nhap:");
            arr.xuatMang();

            Console.WriteLine();
            arr.sapXep(0);  // sap xep tang
            Console.Write("Sap xep tang dan:");
            arr.xuatMang();

            Console.WriteLine();
            arr.sapXep(1);  // sap xep giam
            Console.Write("Sap xep giam dan:");
            arr.xuatMang();

            Console.WriteLine("\n");
            Console.Write("Nhap so can tim: ");
            double x = double.Parse(Console.ReadLine());

            List<int> result = new List<int>();
            result = arr.timKiem(x);
            Console.WriteLine();
            arr.xuatMang();
            Console.WriteLine();
            
            if(result.Count == 0)
            {
                Console.WriteLine("Khong co trong mang");
            }
            else
            {
                foreach(int i in result)
                {
                    Console.WriteLine("arr[" + i + "] = " + x);
                }
            }
        }
    }
}