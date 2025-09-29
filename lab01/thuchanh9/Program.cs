using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thực hành 9
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số lượng phần tử n (nguyên dương): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("n không hợp lệ!");
                return;
            }

            var arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                while (!double.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("  Nhập lại (số thực): ");
                }
            }

            double sum = 0;
            foreach (var v in arr) sum += v;

            Console.WriteLine($"Tổng các phần tử = {sum}");

        }
    }
}
