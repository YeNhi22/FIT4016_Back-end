using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SoPhuc A = new SoPhuc();
            SoPhuc B = new SoPhuc();

            Console.WriteLine("Nhập số phức A:");
            A.Nhap();

            Console.WriteLine("\nNhập số phức B:");
            B.Nhap();

            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("a) Tính tổng A + B");
                Console.WriteLine("b) Tính hiệu A - B");
                Console.WriteLine("c) Tính tích A * B");
                Console.WriteLine("d) Tính thương A / B");
                Console.WriteLine("e) Thoát");
                Console.Write("Chọn tác vụ: ");
                string chon = Console.ReadLine();

                try
                {
                    SoPhuc ketQua = null;
                    switch (chon)
                    {
                        case "a":
                            ketQua = A.Cong(B);
                            Console.Write("Tổng A + B = ");
                            ketQua.HienThi();
                            break;
                        case "b":
                            ketQua = A.Tru(B);
                            Console.Write("Hiệu A - B = ");
                            ketQua.HienThi();
                            break;
                        case "c":
                            ketQua = A.Nhan(B);
                            Console.Write("Tích A * B = ");
                            ketQua.HienThi();
                            break;
                        case "d":
                            ketQua = A.Chia(B);
                            Console.Write("Thương A / B = ");
                            ketQua.HienThi();
                            break;
                        case "e":
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
            }
        }
    }
}
