using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh7
{
    internal class Program
    {
        static bool LaTamGiac(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0
                && a + b > c && a + c > b && b + c > a;
        }
        static void Main(string[] args)
        {
            // Thực hành 7
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            

            Console.Write("Nhập a: "); bool okA = double.TryParse(Console.ReadLine(), out double a);
            Console.Write("Nhập b: "); bool okB = double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Nhập c: "); bool okC = double.TryParse(Console.ReadLine(), out double c);

            if (!okA || !okB || !okC)
            {
                Console.WriteLine("Giá trị nhập không hợp lệ!");
                return;
            }

            if (!LaTamGiac(a, b, c))
            {
                Console.WriteLine("Ba đoạn thẳng KHÔNG lập thành tam giác.");
                return;
            }

            double p = a + b + c;      
            double s2 = p / 2.0;       
            double S = Math.Sqrt(s2 * (s2 - a) * (s2 - b) * (s2 - c)); 

            Console.WriteLine($"Chu vi tam giác = {p}");
            Console.WriteLine($"Diện tích tam giác = {S}");

        }
    }
}
