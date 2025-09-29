using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyChiChuong_1150080128
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập dữ liệu
            Console.Write(" Nhap vao chieu dai: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Nhap vao chieu rong: ");
            double b = Convert.ToDouble(Console.ReadLine());
            // Tính chu vi và diện tích
            double fl = (a + b) * 2;
            double S = a * b;
            // iển thị kết quả
            Console.WriteLine("Chu vi la: " + fl);
            Console.WriteLine("Dien tich la: " + S);
        }
    }
}
