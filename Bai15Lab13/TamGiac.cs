using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15Lab13
{
    internal class TamGiac : DaGiac
    {
        public TamGiac() : base(3)
        {
        }

        public override int TinhChuVi()
        {
            return base.TinhChuVi();
        }

        public double TinhDienTich()
        {
            int a = kichThuocCanh[0];
            int b = kichThuocCanh[1];
            int c = kichThuocCanh[2];
            double p = TinhChuVi() / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Công thức Heron
        }

        public bool LaTamGiacPitago()
        {
            int[] canh = (int[])kichThuocCanh.Clone();
            Array.Sort(canh);
            return canh[0] * canh[0] + canh[1] * canh[1] == canh[2] * canh[2];
        }
    }
}
