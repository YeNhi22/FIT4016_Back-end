using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12Lab13
{
    internal class main
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== Nhập ma trận A ===");
            MaTran A = new MaTran();
            A.Nhap();

            Console.WriteLine("=== Nhập ma trận B ===");
            MaTran B = new MaTran();
            B.Nhap();

            while (true)
            {
                Console.WriteLine("\nChọn tác vụ:");
                Console.WriteLine("1. Tính tổng hai ma trận");
                Console.WriteLine("2. Tính hiệu hai ma trận");
                Console.WriteLine("3. Tính tích hai ma trận");
                Console.WriteLine("4. Tính thương hai ma trận");
                Console.WriteLine("5. Thoát");

                Console.Write("Nhập lựa chọn: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        if (A.CungCap(B))
                        {
                            Console.WriteLine("Tổng hai ma trận:");
                            MaTran.Tong(A, B).HienThi();
                        }
                        else Console.WriteLine("Hai ma trận không cùng cấp.");
                        break;

                    case "2":
                        if (A.CungCap(B))
                        {
                            Console.WriteLine("Hiệu hai ma trận:");
                            MaTran.Hieu(A, B).HienThi();
                        }
                        else Console.WriteLine("Hai ma trận không cùng cấp.");
                        break;

                    case "3":
                        if (A.HopLeNhan(B))
                        {
                            Console.WriteLine("Tích hai ma trận:");
                            MaTran.Tich(A, B).HienThi();
                        }
                        else Console.WriteLine("Không thể nhân hai ma trận.");
                        break;

                    case "4":
                        if (A.CungCap(B))
                        {
                            Console.WriteLine("Thương hai ma trận:");
                            MaTran.Thuong(A, B).HienThi();
                        }
                        else Console.WriteLine("Hai ma trận không cùng cấp.");
                        break;

                    case "5":
                        Console.WriteLine("Thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }
    }
}
