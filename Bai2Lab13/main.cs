using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab13
{
    internal class main
    {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            QuanLyTaiLieu qltl = new QuanLyTaiLieu();

            while (true) {
                Console.WriteLine("\n==========Quản lý tài liệu================");
                Console.WriteLine("1. Thêm tài liệu");
                Console.WriteLine("2. Hiển thị danh sách tài liệu.");
                Console.WriteLine("3. Tìm kiếm theo loại");
                Console.WriteLine("4. Thoát");
                Console.WriteLine("Chọn chức năng: ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        qltl.ThemTaiLieu();
                        break;
                    case "2":
                        qltl.HienThiDanhSach();
                        break;
                    case "3":
                        qltl.TimKiemTheoLoai();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
