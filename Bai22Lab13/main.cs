using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22Lab13
{
    internal class main
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số học sinh: ");
            int n = int.Parse(Console.ReadLine());
            List<HocSinh> danhSach = new List<HocSinh>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n-- Nhập học sinh thứ {i + 1} --");
                HocSinh hs = new HocSinh();
                hs.Nhap();
                danhSach.Add(hs);
            }

            // Sắp xếp danh sách
            danhSach.Sort();

            // Chuyển chữ cái đầu sang hoa
            foreach (var hs in danhSach)
            {
                hs.ChuanHoaHoTen();
            }

            // Hiển thị kết quả
            Console.WriteLine("\n--- Danh sách sau khi sắp xếp ---");
            foreach (var hs in danhSach)
            {
                hs.HienThi();
            }
        }
    }
}
