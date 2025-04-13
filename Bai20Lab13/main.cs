using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<HoiVien> danhSachHoiVien = new List<HoiVien>();

            Console.Write("Nhập số lượng hội viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Hội viên thứ {i + 1} ---");
                Console.WriteLine("1. Đã có gia đình");
                Console.WriteLine("2. Đã có người yêu");
                Console.WriteLine("3. Chưa có người yêu");
                Console.Write("Chọn loại hội viên: ");
                int loai = int.Parse(Console.ReadLine());

                HoiVien hv;
                switch (loai)
                {
                    case 1:
                        hv = new DaCoGiaDinh();
                        break;
                    case 2:
                        hv = new DaCoNguoiYeu();
                        break;
                    default:
                        hv = new HoiVien("", "");
                        break;
                }
                hv.NhapThongTin();
                danhSachHoiVien.Add(hv);
            }

            Console.WriteLine("\n=== Hội viên cưới ngày 11/11/2011 ===");
            foreach (var hv in danhSachHoiVien)
                if (hv.CoNgayCuoi11_11_2011()) hv.HienThiThongTin();

            Console.WriteLine("\n=== Hội viên có người yêu nhưng chưa lập gia đình ===");
            foreach (var hv in danhSachHoiVien)
                if (hv.CoNguoiYeuChuaCuoi()) hv.HienThiThongTin();
        }
    }
}

