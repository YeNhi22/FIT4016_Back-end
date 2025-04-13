using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18Lab13
{
    internal class CoQuan : Nguoi
    {
        public string DonVi { get; set; }
        public double HeSoLuong { get; set; }
        public const double LUONG_CO_BAN = 1050000;

        public CoQuan() { }

        public CoQuan(string hoTen, bool gioiTinh, int tuoi, string donVi, double heSoLuong)
            : base(hoTen, gioiTinh, tuoi)
        {
            DonVi = donVi;
            HeSoLuong = heSoLuong;
        }

        public override void In()
        {
            base.In();
            Console.WriteLine($"Đơn vị: {DonVi}, Hệ số lương: {HeSoLuong}, Lương: {TinhLuong()} VNĐ");
        }

        public double TinhLuong()
        {
            return HeSoLuong * LUONG_CO_BAN;
        }
    }
}
