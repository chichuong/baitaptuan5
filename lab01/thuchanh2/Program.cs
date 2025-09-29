using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tìm max trong 2 số nguyên a, b
            // hập dữ liệu
            Console.Write(" hap vao so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" hap vao so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            // Tìm số max
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            if (b > a)
            {
                max = b;
            }
            // iển thị kết quả
            Console.WriteLine("So lon hon trong 2 so la: " + max);
        }
    }
}
