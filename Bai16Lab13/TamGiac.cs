using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16Lab13
{
    internal class TamGiac
    {
        public Diem D1 { get; set; }
        public Diem D2 { get; set; }
        public Diem D3 { get; set; }

        public TamGiac()
        {
            D1 = new Diem();
            D2 = new Diem();
            D3 = new Diem();
        }

        public TamGiac(Diem d1, Diem d2, Diem d3)
        {
            D1 = d1;
            D2 = d2;
            D3 = d3;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập điểm thứ 1:");
            D1 = new Diem();
            D1.Nhap();
            Console.WriteLine("Nhập điểm thứ 2:");
            D2 = new Diem();
            D2.Nhap();
            Console.WriteLine("Nhập điểm thứ 3:");
            D3 = new Diem();
            D3.Nhap();
        }

        public void Xuat()
        {
            Console.Write("Điểm 1: "); D1.Xuat();
            Console.Write("Điểm 2: "); D2.Xuat();
            Console.Write("Điểm 3: "); D3.Xuat();
            Console.WriteLine($"Chu vi: {TinhChuVi():F2}, Diện tích: {TinhDienTich():F2}");
        }

        public double TinhChuVi()
        {
            return D1.TinhKhoangCach(D2) + D2.TinhKhoangCach(D3) + D3.TinhKhoangCach(D1);
        }

        public double TinhDienTich()
        {
            double a = D1.TinhKhoangCach(D2);
            double b = D2.TinhKhoangCach(D3);
            double c = D3.TinhKhoangCach(D1);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
