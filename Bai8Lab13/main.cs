using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<TheMuon> danhSachTheMuon = new List<TheMuon>();

            while (true)
            {
                Console.WriteLine("\n===== Quản lý mượn sách - Thư viện Đại Nam =====");
                Console.WriteLine("1. Nhập thẻ mượn");
                Console.WriteLine("2. Hiển thị danh sách thẻ mượn");
                Console.WriteLine("3. Tìm sinh viên theo mã số");
                Console.WriteLine("4. Hiển thị sinh viên đến hạn trả sách");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");

                int chon;
                if (!int.TryParse(Console.ReadLine(), out chon)) continue;

                switch (chon)
                {
                    case 1:
                        TheMuon tm = new TheMuon();
                        tm.Nhap();
                        danhSachTheMuon.Add(tm);
                        break;
                    case 2:
                        foreach (var the in danhSachTheMuon)
                        {
                            the.HienThi();
                        }
                        break;
                    case 3:
                        Console.Write("Nhập mã số sinh viên cần tìm: ");
                        string maSV = Console.ReadLine();
                        foreach (var the in danhSachTheMuon)
                        {
                            if (the.SinhVien.MaSoSV == maSV)
                                the.HienThi();
                        }
                        break;
                    case 4:
                        DateTime today = DateTime.Today;
                        Console.WriteLine($"\nSinh viên đến hạn trả sách (trước hoặc bằng {today:yyyy-MM-dd}):");
                        foreach (var the in danhSachTheMuon)
                        {
                            if (the.HanTra <= today)
                                the.HienThi();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Đã thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}
