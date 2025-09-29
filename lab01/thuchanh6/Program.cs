using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thực hành 6
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chiều dài d (> 0): ");
            bool okD = double.TryParse(Console.ReadLine(), out double d);
            Console.Write("Nhập chiều rộng r (> 0): ");
            bool okR = double.TryParse(Console.ReadLine(), out double r);

            if (!okD || !okR || d <= 0 || r <= 0)
            {
                Console.WriteLine("Dữ liệu không hợp lệ (phải là số thực dương).");
                return;
            }

            double chuVi = 2 * (d + r);
            double dienTich = d * r;

            Console.WriteLine($"Chu vi = {chuVi}");
            Console.WriteLine($"Diện tích = {dienTich}");

        }
    }
}
