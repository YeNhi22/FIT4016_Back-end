using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Lab1._3
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            QuanLyCanBo quanLyCanBo = new QuanLyCanBo();
            while (true)
            {
                Console.WriteLine("==========Chương trình quản lý cán bộ============");
                Console.WriteLine("1. Thêm cán bộ");
                Console.WriteLine("2. Tìm kiếm cán bộ theo họ tên");
                Console.WriteLine("3. Hiển thị danh sách cán bộ");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string input = Console.ReadLine() ?? string.Empty; // Ensure input is not null
                if (int.TryParse(input, out int luaChon))
                {
                    switch (luaChon)
                    {
                        case 1:
                            quanLyCanBo.ThemCanBo();
                            break;
                        case 2:
                            quanLyCanBo.TimKiem();
                            break;
                        case 3:
                            quanLyCanBo.HienThiDanhSach();
                            break;
                        case 4:
                            Console.WriteLine("Thoát chương trình.");
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                }
            }
        }
    }
}
