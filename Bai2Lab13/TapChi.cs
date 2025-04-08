using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab13
{
    internal class TapChi : TaiLieu
    {
        private int soPhatHanh;
        private string? thangPhatHanh;

        //phuong thuc khoi tao mac dinh
        public TapChi() { }

        //phuong thuc khoi tao co tham so
        public TapChi(string maTL, string tenNXB, int soBan, int soPhatHanh, string thangPhatHanh) : base(maTL, tenNXB, soBan)
        {
            this.soPhatHanh = soPhatHanh;
            this.thangPhatHanh = thangPhatHanh;
        }

        //phuong thuc nhap thong tin tap chi
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("+ So phat hanh: ");
            soPhatHanh = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("+ Thang phat hanh: ");
            thangPhatHanh = Console.ReadLine();
        }

        //phuong thuc hien thi thong tin tap chi
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ So phat hanh: {soPhatHanh} ");
            Console.WriteLine($"+ Thang phat hanh: {thangPhatHanh} ");
        }
    }
}
