using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tìm max trong 3 số nguyên a, b, c
            // hập dữ liệu
            Console.Write(" hap vao so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" hap vao so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" hap vao so nguyen c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            // Tìm số max
            int max = 0;
            if ((a > b) && (a > c))
            {
                max = a;
            }
            else if ((b > a) && (b > c))
            {
            }
            else
            {
            }
            max = b;

            max = c;
            // iển thị kết quả
            Console.WriteLine("So lon nhat trong 3 so la: {0}", max);
        }
    }
}
