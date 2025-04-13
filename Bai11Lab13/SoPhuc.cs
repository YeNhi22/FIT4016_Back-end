using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11Lab13
{
    internal class SoPhuc
    {
        public double PhanThuc { get; set; }
        public double PhanAo { get; set; }

        public SoPhuc()
        {
            PhanThuc = 0;
            PhanAo = 0;
        }

        public SoPhuc(double a, double b)
        {
            PhanThuc = a;
            PhanAo = b;
        }

        public void Nhap()
        {
            Console.Write("Nhập phần thực: ");
            PhanThuc = double.Parse(Console.ReadLine());

            Console.Write("Nhập phần ảo: ");
            PhanAo = double.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            string dau = PhanAo >= 0 ? "+" : "-";
            Console.WriteLine($"{PhanThuc} {dau} {Math.Abs(PhanAo)}i");
        }

        public SoPhuc Cong(SoPhuc sp)
        {
            return new SoPhuc(this.PhanThuc + sp.PhanThuc, this.PhanAo + sp.PhanAo);
        }

        public SoPhuc Tru(SoPhuc sp)
        {
            return new SoPhuc(this.PhanThuc - sp.PhanThuc, this.PhanAo - sp.PhanAo);
        }

        public SoPhuc Nhan(SoPhuc sp)
        {
            double a = this.PhanThuc * sp.PhanThuc - this.PhanAo * sp.PhanAo;
            double b = this.PhanThuc * sp.PhanAo + this.PhanAo * sp.PhanThuc;
            return new SoPhuc(a, b);
        }

        public SoPhuc Chia(SoPhuc sp)
        {
            double mau = sp.PhanThuc * sp.PhanThuc + sp.PhanAo * sp.PhanAo;
            if (mau == 0)
                throw new DivideByZeroException("Không thể chia cho số phức có cả phần thực và ảo bằng 0.");

            double a = (this.PhanThuc * sp.PhanThuc + this.PhanAo * sp.PhanAo) / mau;
            double b = (this.PhanAo * sp.PhanThuc - this.PhanThuc * sp.PhanAo) / mau;
            return new SoPhuc(a, b);
        }
    }
}
