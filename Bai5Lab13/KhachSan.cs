using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5Lab13
{
    internal class KhachSan
    {
        public Nguoi ThongTinKhach { get; set; }
        public int SoNgayTro { get; set; }
        public string LoaiPhong { get; set; }
        public double GiaPhong { get; set; }

        public void Nhap()
        {
            ThongTinKhach = new Nguoi();
            ThongTinKhach.Nhap();
            Console.Write("Nhập số ngày trọ: ");
            SoNgayTro = int.Parse(Console.ReadLine());
            Console.Write("Nhập loại phòng: ");
            LoaiPhong = Console.ReadLine();
            Console.Write("Nhập giá phòng/ngày: ");
            GiaPhong = double.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            ThongTinKhach.HienThi();
            Console.WriteLine($"Loại phòng: {LoaiPhong}, Số ngày trọ: {SoNgayTro}, Giá phòng/ngày: {GiaPhong}");
        }

        public double TinhTien()
        {
            return SoNgayTro * GiaPhong;
        }
    }
}
