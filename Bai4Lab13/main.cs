using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            KhuPho khuPho = new KhuPho();

            while (true)
            {
                Console.WriteLine("\n========= Quản lý Khu Phố =========");
                Console.WriteLine("1. Nhập thông tin các hộ dân");
                Console.WriteLine("2. Hiển thị thông tin toàn bộ khu phố");
                Console.WriteLine("3. Tìm kiếm hộ dân theo họ tên");
                Console.WriteLine("4. Tìm kiếm hộ dân theo số nhà");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        khuPho.NhapDanhSach();
                        break;
                    case "2":
                        khuPho.HienThiTatCa();
                        break;
                    case "3":
                        khuPho.TimTheoTen();
                        break;
                    case "4":
                        khuPho.TimTheoSoNha();
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
