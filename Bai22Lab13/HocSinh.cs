using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22Lab13
{
    internal class HocSinh : IComparable<HocSinh>
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public double TongDiem { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập tổng điểm: ");
            TongDiem = double.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Tổng điểm: {TongDiem}");
        }

        public int CompareTo(HocSinh other)
        {
            // So sánh giảm dần tổng điểm
            int cmp = other.TongDiem.CompareTo(this.TongDiem);
            if (cmp == 0)
            {
                // Nếu tổng điểm bằng nhau thì so sánh năm sinh tăng dần (người sinh trước đứng trước)
                return this.NamSinh.CompareTo(other.NamSinh);
            }
            return cmp;
        }

        public void ChuanHoaHoTen()
        {
            TextInfo ti = new CultureInfo("vi-VN", false).TextInfo;
            HoTen = ti.ToTitleCase(HoTen.ToLower());
        }
    }
}
