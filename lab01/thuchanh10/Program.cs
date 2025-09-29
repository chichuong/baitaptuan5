using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace thuchanh10
{
    internal class Program
    {
        // Hàm đọc mảng từ file
        static int[] ReadIntArrayFromFile(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException($"Không tìm thấy file: {path}");
            var text = File.ReadAllText(path);
            var tokens = text.Replace(",", " ").Split(new[] { ' ', '\t', '\r', '\n' },
                                                     StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();
            foreach (var tk in tokens)
            {
                int v;
                if (int.TryParse(tk, out v)) list.Add(v);
                else throw new FormatException($"Giá trị không phải số nguyên: \"{tk}\"");
            }
            return list.ToArray();
        }

        // Hàm sắp xếp chọn
        static void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] < a[minIdx]) minIdx = j;

                if (minIdx != i)
                {
                    int tmp = a[i];
                    a[i] = a[minIdx];
                    a[minIdx] = tmp;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            try
            {
                string inPath = "input_array.txt";
                string outPath = "sorted_array.txt";

                int[] data = ReadIntArrayFromFile(inPath);
                SelectionSort(data);

                File.WriteAllText(outPath, string.Join(" ", data), Encoding.UTF8);

                Console.WriteLine($"Đã sắp xếp tăng dần. Kết quả được ghi vào: {outPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}
