using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9Lab13
{
    internal class BienLai
    {
        public KhachHang KhachHang { get; set; } = new KhachHang();
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }

        public void NhapBienLai()
        {
            KhachHang.NhapThongTin();

            Console.Write("Nhập chỉ số cũ: ");
            ChiSoCu = int.Parse(Console.ReadLine());

            Console.Write("Nhập chỉ số mới: ");
            ChiSoMoi = int.Parse(Console.ReadLine());
        }

        public int TinhTienDien()
        {
            int soDien = ChiSoMoi - ChiSoCu;
            if (soDien < 50)
                return soDien * 1250;
            else if (soDien < 100)
                return soDien * 1500;
            else
                return soDien * 2000;
        }

        public void HienThiBienLai()
        {
            KhachHang.HienThiThongTin();
            Console.WriteLine($"Chỉ số cũ: {ChiSoCu}, Chỉ số mới: {ChiSoMoi}, Tiền điện: {TinhTienDien()} VNĐ");
        }
    }
}
