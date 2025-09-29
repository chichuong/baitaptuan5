using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace thuchanh11
{
    internal class Program
    {
        // Đọc mảng từ file (đã sắp xếp tăng dần)
        static int[] ReadSortedIntArray(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Không tìm thấy file: {path}");

            var text = File.ReadAllText(path);
            var tokens = text.Replace(",", " ")
                             .Split(new[] { ' ', '\t', '\r', '\n' },
                                    StringSplitOptions.RemoveEmptyEntries);

            var list = new List<int>();
            foreach (var tk in tokens)
            {
                int v;
                if (int.TryParse(tk, out v)) list.Add(v);
                else throw new FormatException($"Giá trị không phải số nguyên: \"{tk}\"");
            }

            // Kiểm tra xem mảng có tăng dần không
            for (int i = 1; i < list.Count; i++)
                if (list[i] < list[i - 1])
                    throw new InvalidOperationException("Mảng trong file chưa được sắp xếp tăng dần.");

            return list.ToArray();
        }

        // Hàm tìm vị trí chèn (binary search)
        static int LowerBound(int[] a, int x)
        {
            int l = 0, r = a.Length;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (a[m] < x) l = m + 1;
                else r = m;
            }
            return l;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            try
            {
                string inPath = "sorted_array.txt";   
                string outPath = "sorted_array_after_insert.txt";

                int[] a = ReadSortedIntArray(inPath);

                Console.Write("Nhập số nguyên cần chèn: ");
                int x;
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ!");
                    return;
                }

                // Tìm vị trí chèn
                int pos = LowerBound(a, x);

                // Tạo mảng mới lớn hơn 1 phần tử
                var b = new int[a.Length + 1];
                Array.Copy(a, 0, b, 0, pos);
                b[pos] = x;
                Array.Copy(a, pos, b, pos + 1, a.Length - pos);

                Console.WriteLine("Mảng sau khi chèn:");
                Console.WriteLine(string.Join(" ", b));

                File.WriteAllText(outPath, string.Join(" ", b), Encoding.UTF8);
                Console.WriteLine($"Đã lưu vào file: {outPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}
