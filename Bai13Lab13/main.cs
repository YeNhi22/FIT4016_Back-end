using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            QuanLyPTGT ql = new QuanLyPTGT();
            while (true)
            {
                Console.WriteLine("\n==== Quản lý phương tiện giao thông ====");
                Console.WriteLine("1. Nhập đăng ký phương tiện");
                Console.WriteLine("2. Hiển thị tất cả phương tiện");
                Console.WriteLine("3. Tìm theo màu");
                Console.WriteLine("4. Tìm theo năm sản xuất");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1": ql.NhapPhuongTien(); break;
                    case "2": ql.HienThi(); break;
                    case "3": ql.TimTheoMau(); break;
                    case "4": ql.TimTheoNam(); break;
                    case "5": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
                }
            }
        }
    }
}
