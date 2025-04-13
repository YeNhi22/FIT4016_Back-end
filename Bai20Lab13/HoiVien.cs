using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20Lab13
{
    internal class HoiVien
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        public HoiVien(string hoTen, string diaChi)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
        }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Địa chỉ: {DiaChi}");
        }

        public virtual bool CoNgayCuoi11_11_2011() => false;
        public virtual bool CoNguoiYeuChuaCuoi() => false;
    }
}

