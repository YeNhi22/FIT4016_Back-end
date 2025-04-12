using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<KhachSan> danhSach = new List<KhachSan>();
            while (true)
            {
                Console.WriteLine("\n===== CHƯƠNG TRÌNH QUẢN LÝ KHÁCH SẠN =====");
                Console.WriteLine("1. Nhập thông tin khách trọ");
                Console.WriteLine("2. Hiển thị danh sách khách trọ");
                Console.WriteLine("3. Tìm kiếm khách theo họ tên");
                Console.WriteLine("4. Tính tiền khách trả phòng");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        Console.Write("Nhập số lượng khách trọ: ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"\nNhập khách hàng thứ {i + 1}:");
                            KhachSan ks = new KhachSan();
                            ks.Nhap();
                            danhSach.Add(ks);
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n===== DANH SÁCH KHÁCH TRỌ =====");
                        foreach (var ks in danhSach)
                        {
                            ks.HienThi();
                            Console.WriteLine("----------------------------");
                        }
                        break;

                    case "3":
                        Console.Write("Nhập họ tên cần tìm: ");
                        string hoTen = Console.ReadLine();
                        foreach (var ks in danhSach)
                        {
                            if (ks.ThongTinKhach.HoTen.Contains(hoTen, StringComparison.OrdinalIgnoreCase))
                            {
                                ks.HienThi();
                                Console.WriteLine("----------------------------");
                            }
                        }
                        break;

                    case "4":
                        Console.Write("Nhập số CMND khách cần tính tiền: ");
                        string cmnd = Console.ReadLine();
                        var khach = danhSach.Find(k => k.ThongTinKhach.CMND == cmnd);
                        if (khach != null)
                        {
                            double tien = khach.TinhTien();
                            Console.WriteLine($"Tổng tiền khách phải trả là: {tien:N0} VND");
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy khách có CMND đó.");
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
