using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14Lab13
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        // Toán tử tạo lập không tham số
        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        // Toán tử tạo lập có tham số
        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau != 0 ? mau : 1; // tránh chia cho 0
        }

        // Nhập phân số
        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhập mẫu số (khác 0): ");
                MauSo = int.Parse(Console.ReadLine());
                if (MauSo == 0)
                    Console.WriteLine("Mẫu số phải khác 0!");
            } while (MauSo == 0);
        }

        // Hiển thị phân số
        public void HienThi()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        // Rút gọn phân số
        public void RutGon()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /= ucln;
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        // Tính UCLN
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        // Cộng hai phân số
        public PhanSo Cong(PhanSo ps)
        {
            int tu = TuSo * ps.MauSo + ps.TuSo * MauSo;
            int mau = MauSo * ps.MauSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }

        // Trừ hai phân số
        public PhanSo Tru(PhanSo ps)
        {
            int tu = TuSo * ps.MauSo - ps.TuSo * MauSo;
            int mau = MauSo * ps.MauSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }

        // Chia hai phân số
        public PhanSo Chia(PhanSo ps)
        {
            int tu = TuSo * ps.MauSo;
            int mau = MauSo * ps.TuSo;
            PhanSo kq = new PhanSo(tu, mau);
            kq.RutGon();
            return kq;
        }
    }
}
