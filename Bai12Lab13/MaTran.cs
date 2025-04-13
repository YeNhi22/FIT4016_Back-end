using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12Lab13
{
    internal class MaTran
    {
        private int soDong, soCot;
        private double[,] duLieu;

        // Constructor mặc định
        public MaTran()
        {
            soDong = 0;
            soCot = 0;
            duLieu = new double[0, 0];
        }

        // Constructor có tham số
        public MaTran(int n, int m)
        {
            soDong = n;
            soCot = m;
            duLieu = new double[n, m];
        }

        // Phương thức nhập ma trận
        public void Nhap()
        {
            Console.Write("Nhập số dòng: ");
            soDong = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            soCot = int.Parse(Console.ReadLine());
            duLieu = new double[soDong, soCot];

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"Phần tử [{i},{j}]: ");
                    duLieu[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }

        // Phương thức hiển thị ma trận
        public void HienThi()
        {
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(duLieu[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Tổng hai ma trận
        public static MaTran Tong(MaTran a, MaTran b)
        {
            MaTran kq = new MaTran(a.soDong, a.soCot);
            for (int i = 0; i < a.soDong; i++)
            {
                for (int j = 0; j < a.soCot; j++)
                {
                    kq.duLieu[i, j] = a.duLieu[i, j] + b.duLieu[i, j];
                }
            }
            return kq;
        }

        // Hiệu hai ma trận
        public static MaTran Hieu(MaTran a, MaTran b)
        {
            MaTran kq = new MaTran(a.soDong, a.soCot);
            for (int i = 0; i < a.soDong; i++)
            {
                for (int j = 0; j < a.soCot; j++)
                {
                    kq.duLieu[i, j] = a.duLieu[i, j] - b.duLieu[i, j];
                }
            }
            return kq;
        }

        // Tích hai ma trận
        public static MaTran Tich(MaTran a, MaTran b)
        {
            MaTran kq = new MaTran(a.soDong, b.soCot);
            for (int i = 0; i < a.soDong; i++)
            {
                for (int j = 0; j < b.soCot; j++)
                {
                    kq.duLieu[i, j] = 0;
                    for (int k = 0; k < a.soCot; k++)
                    {
                        kq.duLieu[i, j] += a.duLieu[i, k] * b.duLieu[k, j];
                    }
                }
            }
            return kq;
        }

        // Thương hai ma trận (chia phần tử tương ứng)
        public static MaTran Thuong(MaTran a, MaTran b)
        {
            MaTran kq = new MaTran(a.soDong, a.soCot);
            for (int i = 0; i < a.soDong; i++)
            {
                for (int j = 0; j < a.soCot; j++)
                {
                    kq.duLieu[i, j] = b.duLieu[i, j] != 0 ? a.duLieu[i, j] / b.duLieu[i, j] : 0;
                }
            }
            return kq;
        }

        // Kiểm tra cùng cấp
        public bool CungCap(MaTran b)
        {
            return this.soDong == b.soDong && this.soCot == b.soCot;
        }

        // Kiểm tra điều kiện nhân ma trận
        public bool HopLeNhan(MaTran b)
        {
            return this.soCot == b.soDong;
        }
    }
}
