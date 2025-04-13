using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18Lab13
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; } // true: Nam, false: Nữ
        public int Tuoi { get; set; }

        public Nguoi() { }

        public Nguoi(string hoTen, bool gioiTinh, int tuoi)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
        }

        public virtual void In()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Giới tính: {(GioiTinh ? "Nam" : "Nữ")}, Tuổi: {Tuoi}");
        }
    }
}
