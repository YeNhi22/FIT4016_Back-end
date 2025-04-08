using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab13
{
    internal class Bao : TaiLieu
    {
        private string? ngayPhatHanh;
        //phuong thuc khoi tao mac dinh
        public Bao() { }

        //phuong thuc khoi tao co tham so
        public Bao(string maTL, string tenNXB, int soBan, string ngayPhatHanh) : base(maTL, tenNXB, soBan)
        {
            this.ngayPhatHanh = ngayPhatHanh;
        }

        //phuong thuc nhap thong tin bao
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("+ Ngay phat hanh: ");
            ngayPhatHanh = Console.ReadLine();
        }

        //phuong thuc hien thi thong tin bao
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ Ngay phat hanh: {ngayPhatHanh} ");
        }
    }
}
