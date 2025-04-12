using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7Lab13
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string SoCMND { get; set; }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nhập số CMND: ");
            SoCMND = Console.ReadLine();
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, Số CMND: {SoCMND}");
        }
    }
}
