using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng hình tròn: ");
            int n = int.Parse(Console.ReadLine());
            List<HinhTron> danhSach = new List<HinhTron>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin hình tròn thứ {i + 1}:");
                HinhTron ht = new HinhTron();
                ht.Nhap();
                danhSach.Add(ht);
            }

            int maxGiao = 0;
            HinhTron hinhTronMax = null;

            for (int i = 0; i < danhSach.Count; i++)
            {
                int dem = 0;
                for (int j = 0; j < danhSach.Count; j++)
                {
                    if (i != j && danhSach[i].GiaoNhau(danhSach[j]))
                        dem++;
                }

                if (dem > maxGiao)
                {
                    maxGiao = dem;
                    hinhTronMax = danhSach[i];
                }
            }

            Console.WriteLine("\n==> Hình tròn giao với nhiều hình tròn khác nhất:");
            if (hinhTronMax != null)
                hinhTronMax.Xuat();
            else
                Console.WriteLine("Không có hình tròn nào giao nhau.");
        }
    }
}

