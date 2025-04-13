using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15Lab13
{
    internal class DaGiac
    {
        protected int soCanh;
        protected int[] kichThuocCanh;

        public DaGiac(int soCanh)
        {
            this.soCanh = soCanh;
            kichThuocCanh = new int[soCanh];
        }

        public void NhapCacCanh()
        {
            Console.WriteLine($"Nhập độ dài {soCanh} cạnh của đa giác:");
            for (int i = 0; i < soCanh; i++)
            {
                Console.Write($"Cạnh {i + 1}: ");
                kichThuocCanh[i] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        public virtual int TinhChuVi()
        {
            int chuVi = 0;
            foreach (var canh in kichThuocCanh)
            {
                chuVi += canh;
            }
            return chuVi;
        }

        public virtual void InCacCanh()
        {
            Console.Write("Các cạnh: ");
            foreach (var canh in kichThuocCanh)
            {
                Console.Write($"{canh} ");
            }
            Console.WriteLine();
        }

        public int[] LayCacCanh()
        {
            return kichThuocCanh;
        }
    }
}
