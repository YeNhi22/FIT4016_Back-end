using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17Lab13
{
    internal class HinhTron
    {
        public Diem tam { get; set; }
        public float banKinh { get; set; }

        public HinhTron()
        {
            tam = new Diem();
            banKinh = 0;
        }

        public HinhTron(Diem d, float bk)
        {
            tam = d;
            banKinh = bk;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập tâm hình tròn:");
            tam = new Diem();
            tam.Nhap();
            Console.Write("Nhập bán kính: ");
            banKinh = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write("Tâm: ");
            tam.Xuat();
            Console.WriteLine($"Bán kính: {banKinh}");
            Console.WriteLine($"Chu vi: {TinhChuVi():F2}");
            Console.WriteLine($"Diện tích: {TinhDienTich():F2}");
        }

        public double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }

        public double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }

        public bool GiaoNhau(HinhTron ht)
        {
            double kc = tam.TinhKhoangCach(ht.tam);
            return kc <= (banKinh + ht.banKinh) && kc >= Math.Abs(banKinh - ht.banKinh);
        }
    }
}
