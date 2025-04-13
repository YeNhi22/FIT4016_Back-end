using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<HocSinh> danhSachHocSinh = new List<HocSinh>();

            Console.Write("Nhập số học sinh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin học sinh thứ {i + 1} ---");
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Giới tính (Nam/Nữ): ");
                string gioiTinh = Console.ReadLine();
                Console.Write("Điểm Toán: ");
                double toan = double.Parse(Console.ReadLine());
                Console.Write("Điểm Lý: ");
                double ly = double.Parse(Console.ReadLine());
                Console.Write("Điểm Hóa: ");
                double hoa = double.Parse(Console.ReadLine());

                double diemPhu;
                if (gioiTinh.ToLower() == "nam")
                {
                    Console.Write("Điểm Kỹ thuật: ");
                    diemPhu = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Điểm Nữ công: ");
                    diemPhu = double.Parse(Console.ReadLine());
                }

                danhSachHocSinh.Add(new HocSinh(hoTen, gioiTinh, toan, ly, hoa, diemPhu));
            }

            Console.WriteLine("\n--- Học sinh nam có điểm kỹ thuật >= 8 ---");
            foreach (var hs in danhSachHocSinh)
            {
                if (hs.GioiTinh.ToLower() == "nam" && hs.DiemPhu >= 8)
                {
                    hs.HienThi();
                }
            }

            Console.WriteLine("\n--- Danh sách học sinh nam ---");
            foreach (var hs in danhSachHocSinh)
            {
                if (hs.GioiTinh.ToLower() == "nam")
                {
                    hs.HienThi();
                }
            }

            Console.WriteLine("\n--- Danh sách học sinh nữ ---");
            foreach (var hs in danhSachHocSinh)
            {
                if (hs.GioiTinh.ToLower() == "nữ")
                {
                    hs.HienThi();
                }
            }
        }
    }
}

