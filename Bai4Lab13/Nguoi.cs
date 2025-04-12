using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab13
{
    internal class Nguoi
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }

        public void NhapThongTin()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập số CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập nghề nghiệp: ");
            NgheNghiep = Console.ReadLine();
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}, CMND: {CMND}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Nghề nghiệp: {NgheNghiep}");
        }
    }
}
