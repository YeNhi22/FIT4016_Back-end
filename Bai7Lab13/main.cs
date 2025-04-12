using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<CBGV> danhSachCBGV = new List<CBGV>();

            while (true)
            {
                Console.WriteLine("\n===== Quản lý cán bộ giáo viên =====");
                Console.WriteLine("1. Nhập thông tin cán bộ giáo viên");
                Console.WriteLine("2. Hiển thị danh sách cán bộ giáo viên");
                Console.WriteLine("3. Tìm kiếm cán bộ theo quê quán");
                Console.WriteLine("4. Hiển thị cán bộ có lương thực lĩnh > 5 triệu");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        CBGV cb = new CBGV();
                        cb.NhapThongTin();
                        danhSachCBGV.Add(cb);
                        break;

                    case "2":
                        Console.WriteLine("=== Danh sách cán bộ giáo viên ===");
                        foreach (var gv in danhSachCBGV)
                        {
                            gv.HienThiThongTin();
                        }
                        break;

                    case "3":
                        Console.Write("Nhập quê quán cần tìm: ");
                        string que = Console.ReadLine();
                        foreach (var gv in danhSachCBGV)
                        {
                            if (gv.QueQuan.Equals(que, StringComparison.OrdinalIgnoreCase))
                            {
                                gv.HienThiThongTin();
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("=== Cán bộ có lương thực lĩnh trên 5 triệu ===");
                        foreach (var gv in danhSachCBGV)
                        {
                            if (gv.LuongThucLinh > 5000000)
                            {
                                gv.HienThiThongTin();
                            }
                        }
                        break;

                    case "5":
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

