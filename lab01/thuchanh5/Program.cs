using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Thực hành 5
            Console.Write("Nhập số nguyên n: ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Giá trị nhập không hợp lệ!");
                return;
            }

            Console.WriteLine(n % 2 == 0 ? "n là số CHẴN" : "n là số LẺ");
            Console.WriteLine(n < 0 ? "n là số ÂM" : "n là số KHÔNG ÂM (>= 0)");

        }
    }
}
