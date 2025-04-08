using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab13
{
    internal class TaiLieu
    {
        //Khai bao cac thuoc tinh
        protected string? maTL;
        protected string? tenNXB;
        protected int soBan;

        //phuong thuc khoi tao mac dinh
        public TaiLieu()
        {

        }

        //Phuong thuc khoi tao co tham so
        public TaiLieu(string maTL, string tenNXB, int soBan)
        {
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBan = soBan;
        }

        //Phuong thuc nhap thong tin tai lieu
        public virtual void Nhap()
        {
            Console.Write(" + Ma tai lieu: ");
            maTL = Console.ReadLine();
            Console.Write("+ Ten nha xuat ban: ");
            tenNXB = Console.ReadLine();
            Console.Write("+ So ban: ");
            soBan = int.Parse(Console.ReadLine() ?? "0");
        }

        //Phuong thuc hien thi thong tin tai lieu
        public virtual void Xuat()
        {
            Console.WriteLine($"+ Ma tai lieu: {maTL} ");
            Console.WriteLine($"+ Ten nha xuat ban: {tenNXB} ");
            Console.WriteLine($"+ So ban phat hanh: {soBan} ");
        }
    }
}
