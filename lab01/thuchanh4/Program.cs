using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tháng có bao nhiêu ngày
            // Nhập dữ liệu
            Console.Write(" Nhap vao nam: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap vao thang: ");
            int thang = Convert.ToInt32(Console.ReadLine());
            // Tìm số ngày trong tháng
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang co 31 ngay!");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang co 30 ngay!");
                    break;
                case 2:
                    if ((nam % 400 == 0) || ((nam % 4 == 0) && (nam % 100 != 0)))
                    {
                    }
                    else
                    {
                    }
                    Console.WriteLine("Thang co 29 ngay!");

                    Console.WriteLine("Thang co 28 ngay!");
                    break;
            }
        }
    }
}
