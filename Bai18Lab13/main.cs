using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<CoQuan> danhSach = new List<CoQuan>();

            while (true)
            {
                Console.WriteLine("\n========= QUẢN LÝ CƠ QUAN =========");
                Console.WriteLine("1. Nhập thông tin cá nhân");
                Console.WriteLine("2. Hiển thị cá nhân thuộc Phòng tài chính");
                Console.WriteLine("3. Tìm kiếm theo họ tên");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        Console.Write("Họ tên: ");
                        string hoTen = Console.ReadLine();
                        Console.Write("Giới tính (Nam/Nữ): ");
                        bool gioiTinh = Console.ReadLine().ToLower() == "nam";
                        Console.Write("Tuổi: ");
                        int tuoi = int.Parse(Console.ReadLine());
                        Console.Write("Đơn vị: ");
                        string donVi = Console.ReadLine();
                        Console.Write("Hệ số lương: ");
                        double heSo = double.Parse(Console.ReadLine());

                        danhSach.Add(new CoQuan(hoTen, gioiTinh, tuoi, donVi, heSo));
                        break;

                    case "2":
                        Console.WriteLine("== Danh sách thuộc Phòng tài chính ==");
                        foreach (var caNhan in danhSach)
                        {
                            if (caNhan.DonVi.ToLower().Contains("phòng tài chính"))
                                caNhan.In();
                        }
                        break;

                    case "3":
                        Console.Write("Nhập họ tên cần tìm: ");
                        string tenTim = Console.ReadLine().ToLower();
                        foreach (var caNhan in danhSach)
                        {
                            if (caNhan.HoTen.ToLower().Contains(tenTim))
                                caNhan.In();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("Chức năng không hợp lệ.");
                        break;
                }
            }
        }
    }
}
