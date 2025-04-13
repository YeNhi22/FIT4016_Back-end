using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21Lab13
{
    internal class HocSinh
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public double DiemPhu { get; set; } // Kỹ thuật hoặc Nữ công

        public HocSinh(string hoTen, string gioiTinh, double toan, double ly, double hoa, double diemPhu)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
            DiemPhu = diemPhu;
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen} | Giới tính: {GioiTinh} | Toán: {Toan} | Lý: {Ly} | Hóa: {Hoa} | " +
                              $"{(GioiTinh.ToLower() == "nam" ? "Kỹ thuật" : "Nữ công")}: {DiemPhu}");
        }
    }
}
