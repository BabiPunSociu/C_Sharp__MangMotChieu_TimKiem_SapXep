using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class Binary_Search
    {
        public static int binarySearch(double[] arr, int l, int r, double m)
        {
            Quick_Sort.QuickSort(arr, 0, arr.Length - 1, 0);    // sap xep tang
            if (r >= l)
            {
                int mid = l + (r - l) / 2; // Tương đương (l+r)/2 nhưng ưu điểm tránh tràn số khi l,r lớn

                // Nếu arr[mid] = m, trả về chỉ số và kết thúc.
                if (arr[mid] == m)
                    return mid;

                // Nếu arr[mid] > m, thực hiện tìm kiếm nửa trái của mảng
                if (arr[mid] > m)
                    return binarySearch(arr, l, mid - 1, m);

                // Nếu arr[mid] < x, thực hiện tìm kiếm nửa phải của mảng
                return binarySearch(arr, mid + 1, r, m);
            }

            // Nếu không tìm thấy
            return -1;
        }
    }
}
