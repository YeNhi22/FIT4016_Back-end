using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<HSHocSinh> danhSach = new List<HSHocSinh>();

            while (true)
            {
                Console.WriteLine("\n========== QUẢN LÝ HỒ SƠ HỌC SINH ==========");
                Console.WriteLine("1. Nhập danh sách học sinh");
                Console.WriteLine("2. Hiển thị học sinh nữ, sinh năm 1985");
                Console.WriteLine("3. Tìm học sinh theo quê quán");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Nhập số lượng học sinh: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nNhập thông tin học sinh thứ {i + 1}:");
                            HSHocSinh hs = new HSHocSinh();
                            hs.Nhap();
                            danhSach.Add(hs);
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- Học sinh nữ sinh năm 1985 ---");
                        foreach (var hs in danhSach)
                        {
                            if (hs.GioiTinh.ToLower() == "nữ" && hs.NamSinh == 1985)
                                hs.HienThi();
                        }
                        break;

                    case "3":
                        Console.Write("Nhập quê quán cần tìm: ");
                        string que = Console.ReadLine().ToLower();
                        Console.WriteLine($"\n--- Học sinh quê ở {que} ---");
                        foreach (var hs in danhSach)
                        {
                            if (hs.QueQuan.ToLower().Contains(que))
                                hs.HienThi();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}
