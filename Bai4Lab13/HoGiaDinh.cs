using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab13
{
    internal class HoGiaDinh
    {
        public int SoThanhVien { get; set; }
        public string SoNha { get; set; }
        public List<Nguoi> ThanhVien { get; set; } = new List<Nguoi>();

        public void NhapThongTin()
        {
            Console.Write("Nhập số nhà: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhập số thành viên: ");
            SoThanhVien = int.Parse(Console.ReadLine());

            for (int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"Nhập thông tin thành viên thứ {i + 1}:");
                Nguoi nguoi = new Nguoi();
                nguoi.NhapThongTin();
                ThanhVien.Add(nguoi);
            }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Số nhà: {SoNha}, Số thành viên: {SoThanhVien}");
            foreach (var nguoi in ThanhVien)
            {
                nguoi.HienThiThongTin();
            }
        }

        public bool TimTheoHoTen(string hoTen)
        {
            foreach (var nguoi in ThanhVien)
            {
                if (nguoi.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
