using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab13
{
    internal class Sach : TaiLieu
    {
        private string? tenTG;
        private int soTrang;

        //phuong thuc khoi tao mac dinh
        public Sach() { }

        //phuong thuc khoi tao co tham so
        public Sach(string maTL, string tenNXB, int soBan, string tenTG, int soTrang) : base(maTL, tenNXB, soBan)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }

        //phuong thuc nhap thong tin sach
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("+ Ten tac gia: ");
            tenTG = Console.ReadLine();
            Console.Write("+ So trang: ");
            soTrang = int.Parse(Console.ReadLine() ?? "0");
        }

        //phuong thuc hien thi thong tin sach
        public override void Xuat()
        {
            base.Xuat();
        }
    }
}
