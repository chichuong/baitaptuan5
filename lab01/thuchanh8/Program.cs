using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thực hành 8
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập a: "); bool oka = double.TryParse(Console.ReadLine(), out double A);
            Console.Write("Nhập b: "); bool okb = double.TryParse(Console.ReadLine(), out double B);
            Console.Write("Nhập c: "); bool okc = double.TryParse(Console.ReadLine(), out double C);

            if (!oka || !okb || !okc)
            {
                Console.WriteLine("Giá trị nhập không hợp lệ!");
                return;
            }

            const double EPS = 1e-12;

            if (Math.Abs(A) < EPS) // phương trình bậc nhất: Bx + C = 0
            {
                if (Math.Abs(B) < EPS)
                {
                    Console.WriteLine(Math.Abs(C) < EPS
                        ? "Phương trình vô số nghiệm."
                        : "Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -C / B;
                    Console.WriteLine($"Phương trình bậc nhất, nghiệm x = {x}");
                }
            }
            else
            {
                double delta = B * B - 4 * A * C;
                if (Math.Abs(delta) < EPS)
                {
                    double x = -B / (2 * A);
                    Console.WriteLine($"Phương trình có nghiệm kép x = {x}");
                }
                else if (delta > 0)
                {
                    double sqrtD = Math.Sqrt(delta);
                    double x1 = (-B + sqrtD) / (2 * A);
                    double x2 = (-B - sqrtD) / (2 * A);
                    Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm thực.");
                }
            }

        }
    }
}
