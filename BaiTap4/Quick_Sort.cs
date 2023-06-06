using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class Quick_Sort
    {
        //  phân đoạn trong mảng sap xep tang dan
        public static int Partition_tang(double[] arr, int low, int high)
        {
            double pivot = arr[high];    // khai báo phần tử đánh dâu pivot
            int left = low;   //khai báo biến bên trái
            int right = high - 1; //khai báo biến bên phải
            while (true)
            {
                while (left <= right && arr[left] < pivot) left++; // tìm phần tử >= phần tử pivot trong mảng
                while (right >= left && arr[right] > pivot) right--; // tìm phần tử <= phần tử pivot trong mảng
                if (left >= right) break; // sau khi duyệt xong thì thoát khỏi vòng lặp


                // nếu chưa xong thì sử dụng hàm swap() để tráo đổi.
                double tam = arr[left]; arr[left] = arr[right]; arr[right] = tam;

                left++; // Vì left hiện tại đã xét, nên cần tăng
                right--; // Vì right hiện tại đã xét, nên cần giảm
            };

            // swap(arr[left], arr[high]);
            double t = arr[high]; arr[high] = arr[left]; arr[left] = t;

            return left; // Trả về chỉ số sẽ dùng để chia đôi mảng
        }



        //  phân đoạn trong mảng sap xep giam dan
        public static int Partition_giam(double[] arr, int low, int high)
        {
            double pivot = arr[high];    // khai báo phần tử đánh dâu pivot
            int left = low;   //khai báo biến bên trái
            int right = high - 1; //khai báo biến bên phải
            while (true)
            {
                while (left <= right && arr[left] > pivot) left++; // tìm phần tử <= phần tử pivot trong mảng
                while (right >= left && arr[right] < pivot) right--; // tìm phần tử >= phần tử pivot trong mảng
                if (left >= right) break; // sau khi duyệt xong thì thoát khỏi vòng lặp


                // nếu chưa xong thì sử dụng hàm swap() để tráo đổi.
                double tam = arr[left]; arr[left] = arr[right]; arr[right] = tam;

                left++; // Vì left hiện tại đã xét, nên cần tăng
                right--; // Vì right hiện tại đã xét, nên cần giảm
            };

            // swap(arr[left], arr[high]);
            double t = arr[high]; arr[high] = arr[left]; arr[left] = t;

            return left; // Trả về chỉ số sẽ dùng để chia đôi mảng
        }

        /* Hàm thực hiện giải thuật quick sort */
        public static void QuickSort(double[] arr, int low, int high, int thutu)
        {
            if (low < high)
            {
                // index là chỉ số nơi phần tử này đã đứng đúng vị trí và đây là phần tử chia mảng làm 2 mảng con trái & phải 
                
                if (thutu == 0) 
                { 
                    int index = Partition_tang(arr, low, high);
                    QuickSort(arr, low, index -1, 0);
                    QuickSort(arr, index + 1, high, 0);
                }
                else 
                { 
                    int index = Partition_giam(arr, low, high);
                    // Gọi đệ quy sắp xếp 2 mảng con trái và phải
                    QuickSort(arr, low, index - 1,1);
                    QuickSort(arr, index + 1, high,1);
                }
            }
        }
    }
}
