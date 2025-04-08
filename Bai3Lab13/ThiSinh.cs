using System;

namespace Bai3Lab13
{
    internal abstract class ThiSinh 
    {
        public string SoBaoDanh { get; set; } = string.Empty; 
        public string HoTen { get; set; } = string.Empty; 
        public string DiaChi { get; set; } = string.Empty; 
        public double UuTien { get; set; } 

        public abstract double TinhTongDiem();
        public abstract void Nhap();
        public virtual void Xuat()
        {
            Console.WriteLine($"SBD: {SoBaoDanh}, Họ tên: {HoTen}, Địa chỉ: {DiaChi}, Ưu tiên: {UuTien}");
        }
    }

    internal class ThiSinhKhoiA : ThiSinh
    {
        public double Toan, Ly, Hoa;
        public override double TinhTongDiem() => Toan + Ly + Hoa + UuTien;

        public override void Nhap()
        {
            Console.Write("Nhập SBD: "); SoBaoDanh = Console.ReadLine() ?? string.Empty; 
            Console.Write("Nhập họ tên: "); HoTen = Console.ReadLine() ?? string.Empty; 
            Console.Write("Nhập địa chỉ: "); DiaChi = Console.ReadLine() ?? string.Empty; 
            Console.Write("Điểm Toán: "); Toan = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Điểm Lý: "); Ly = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Điểm Hóa: "); Hoa = double.Parse(Console.ReadLine() ?? "0"); 
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Điểm Toán: {Toan}, Điểm Lý: {Ly}, Điểm Hóa: {Hoa}, Tổng: {TinhTongDiem()}");
        }
    }

    internal class ThiSinhKhoiB : ThiSinh
    {
        public double Toan, Hoa, Sinh;
        public override double TinhTongDiem() => Toan + Hoa + Sinh + UuTien;

        public override void Nhap()
        {
            Console.Write("Nhập SBD: "); SoBaoDanh = Console.ReadLine() ?? string.Empty; 
            Console.Write("Nhập họ tên: "); HoTen = Console.ReadLine() ?? string.Empty; 
            Console.Write("Nhập địa chỉ: "); DiaChi = Console.ReadLine() ?? string.Empty; 
            Console.Write("Nhập điểm ưu tiên: "); UuTien = double.Parse(Console.ReadLine() ?? "0"); 
            Console.Write("Điểm Toán: "); Toan = double.Parse(Console.ReadLine() ?? "0"); 
            Console.Write("Điểm Hóa: "); Hoa = double.Parse(Console.ReadLine() ?? "0"); 
            Console.Write("Điểm Sinh: "); Sinh = double.Parse(Console.ReadLine() ?? "0"); 
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Toán: {Toan}, Hóa: {Hoa}, Sinh: {Sinh}, Tổng: {TinhTongDiem()}");
        }
    }

    internal class ThiSinhKhoiC : ThiSinh
    {
        public double Van, Su, Dia;
        public override double TinhTongDiem() => Van + Su + Dia + UuTien;

        public override void Nhap()
        {
            Console.Write("Nhập SBD: "); SoBaoDanh = Console.ReadLine() ?? string.Empty; 
            Console.Write("Nhập họ tên: "); HoTen = Console.ReadLine() ?? string.Empty; 
            Console.Write("Nhập địa chỉ: "); DiaChi = Console.ReadLine() ?? string.Empty; 
            Console.Write("Nhập điểm ưu tiên: "); UuTien = double.Parse(Console.ReadLine() ?? "0"); 
            Console.Write("Điểm Văn: "); Van = double.Parse(Console.ReadLine() ?? "0"); 
            Console.Write("Điểm Sử: "); Su = double.Parse(Console.ReadLine() ?? "0"); 
            Console.Write("Điểm Địa: "); Dia = double.Parse(Console.ReadLine() ?? "0"); 
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Văn: {Van}, Sử: {Su}, Địa: {Dia}, Tổng: {TinhTongDiem()}");
        }
    }
}
