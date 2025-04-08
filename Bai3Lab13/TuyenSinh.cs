using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3Lab13
{
    internal class TuyenSinh
    {
        private List<ThiSinh> danhSach = new List<ThiSinh>();

        public void NhapThiSinh()
        {
            Console.WriteLine("Chọn khối: 1. A, 2. B, 3. C");
            string chon = Console.ReadLine();
            ThiSinh ts = null;

            switch (chon)
            {
                case "1": ts = new ThiSinhKhoiA(); break;
                case "2": ts = new ThiSinhKhoiB(); break;
                case "3": ts = new ThiSinhKhoiC(); break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ."); return;
            }

            ts.Nhap();
            danhSach.Add(ts);
        }

        public void HienThiTrungTuyen()
        {
            Console.WriteLine("\n--- Danh sách thí sinh trúng tuyển ---");
            foreach (var ts in danhSach)
            {
                if ((ts is ThiSinhKhoiA && ts.TinhTongDiem() >= 15) ||
                    (ts is ThiSinhKhoiB && ts.TinhTongDiem() >= 16) ||
                    (ts is ThiSinhKhoiC && ts.TinhTongDiem() >= 13.5))
                {
                    ts.Xuat();
                }
            }
        }

        public void TimTheoSBD()
        {
            Console.Write("Nhập SBD cần tìm: ");
            string sbd = Console.ReadLine();
            foreach (var ts in danhSach)
            {
                if (ts.SoBaoDanh == sbd)
                {
                    ts.Xuat();
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy thí sinh.");
        }
    }
}
