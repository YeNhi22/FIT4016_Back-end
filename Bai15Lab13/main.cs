using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng tam giác: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            List<TamGiac> danhSachTG = new List<TamGiac>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập tam giác thứ {i + 1}:");
                TamGiac tg = new TamGiac();
                tg.NhapCacCanh();
                danhSachTG.Add(tg);
            }

            Console.WriteLine("\nCác tam giác thỏa mãn định lý Pitago:");
            foreach (var tg in danhSachTG)
            {
                if (tg.LaTamGiacPitago())
                {
                    tg.InCacCanh();
                    Console.WriteLine($"→ Chu vi: {tg.TinhChuVi()}, Diện tích: {tg.TinhDienTich():0.##}\n");
                }
            }
        }
    }
}
