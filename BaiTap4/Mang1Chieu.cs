using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class Mang1Chieu
    {
        private int n = 0;
        double[] a;

        public Mang1Chieu()
        {
            try
            {
                do
                {
                    Console.Write("\nNhap so phan tu cua mang (n>0): n = ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n <= 0);

                a = new double[n];

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void nhapMang()
        {
            try
            {
                Console.Write("Nhap cac gia tri cua mang: ");
                string s = Console.ReadLine().Trim();
                string[] str = s.Split(' ');
                for (int i = 0; i < str.Length; i++)
                {
                    a[i] = Convert.ToDouble(str[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void xuatMang()
        {
            foreach (double i in a)
            {
                Console.Write("   " + i);
            }
        }

        public void sapXep(int thutu)   // thutu=0 : tang dan       // thutu=1 : giam dan
        {
            if(thutu == 0)
            {
                Quick_Sort.QuickSort(a, 0, n - 1,0);
                return;
            }
            Quick_Sort.QuickSort(a, 0, n - 1, 1);
            
        }

        public List<int> timKiem(double m)  // Dùng tìm kiếm nhị phân không tìm được hết các chỉ số nên không sử dụng
        {
            List<int> list = new List<int>();
            
            for(int i = 0; i < n; i++)
            {
                if (a[i] == m)
                    list.Add(i);
            }
            return list;
        }    
    }
}
