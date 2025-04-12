using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6Lab13
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Họ và tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Quê quán: ");
            QueQuan = Console.ReadLine();
            Console.Write("Giới tính (Nam/Nữ): ");
            GioiTinh = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, Giới tính: {GioiTinh}");
        }
    }
}
