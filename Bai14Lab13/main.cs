using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PhanSo A = new PhanSo();
            PhanSo B = new PhanSo();

            Console.WriteLine("=== Nhập phân số A ===");
            A.Nhap();
            A.RutGon();

            Console.WriteLine("=== Nhập phân số B ===");
            B.Nhap();
            B.RutGon();

            while (true)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Hiển thị A và B");
                Console.WriteLine("2. Cộng A + B");
                Console.WriteLine("3. Trừ A - B");
                Console.WriteLine("4. Chia A / B");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.Write("Phân số A: "); A.HienThi();
                        Console.Write("Phân số B: "); B.HienThi();
                        break;

                    case "2":
                        Console.Write("A + B = ");
                        PhanSo tong = A.Cong(B);
                        tong.HienThi();
                        break;

                    case "3":
                        Console.Write("A - B = ");
                        PhanSo hieu = A.Tru(B);
                        hieu.HienThi();
                        break;

                    case "4":
                        Console.Write("A / B = ");
                        PhanSo thuong = A.Chia(B);
                        thuong.HienThi();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
