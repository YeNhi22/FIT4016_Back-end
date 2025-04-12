using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7Lab13
{
    internal class CBGV : Nguoi
    {
        public double LuongCung { get; set; }
        public double Thuong { get; set; }
        public double Phat { get; set; }

        public double LuongThucLinh => LuongCung + Thuong - Phat;

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập lương cứng: ");
            LuongCung = double.Parse(Console.ReadLine());
            Console.Write("Nhập thưởng: ");
            Thuong = double.Parse(Console.ReadLine());
            Console.Write("Nhập phạt: ");
            Phat = double.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Lương cứng: {LuongCung}, Thưởng: {Thuong}, Phạt: {Phat}, Lương thực lĩnh: {LuongThucLinh}");
        }
    }
}
