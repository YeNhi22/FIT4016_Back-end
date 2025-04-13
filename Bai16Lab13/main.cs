using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16Lab13
{
    internal class main
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<TamGiac> danhSachTamGiac = new List<TamGiac>();

            Console.Write("Nhập số lượng tam giác: ");
            int soLuong = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\nNhập tam giác thứ {i + 1}:");
                TamGiac tg = new TamGiac();
                tg.Nhap();
                danhSachTamGiac.Add(tg);
            }

            double tongChuVi = 0, tongDienTich = 0;
            Console.WriteLine("\n=== Danh sách các tam giác ===");
            foreach (var tg in danhSachTamGiac)
            {
                tg.Xuat();
                tongChuVi += tg.TinhChuVi();
                tongDienTich += tg.TinhDienTich();
            }

            Console.WriteLine($"\nTổng chu vi các tam giác: {tongChuVi:F2}");
            Console.WriteLine($"Tổng diện tích các tam giác: {tongDienTich:F2}");
        }
    }
}
