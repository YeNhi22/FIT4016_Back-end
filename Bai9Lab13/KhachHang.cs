using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9Lab13
{
    internal class KhachHang
    {
        public string HoTenChuHo { get; set; }
        public string SoNha { get; set; }
        public string MaCongTo { get; set; }

        public void NhapThongTin()
        {
            Console.Write("Nhập họ tên chủ hộ: ");
            HoTenChuHo = Console.ReadLine();
            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhập mã công tơ: ");
            MaCongTo = Console.ReadLine();
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Chủ hộ: {HoTenChuHo}, Số nhà: {SoNha}, Mã công tơ: {MaCongTo}");
        }
    }
}
