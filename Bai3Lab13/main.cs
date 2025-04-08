using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3Lab13
{
    internal class MainProgram 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TuyenSinh ts = new TuyenSinh();

            while (true)
            {
                Console.WriteLine("\n==== Chương trình tuyển sinh ====");
                Console.WriteLine("1. Nhập thí sinh");
                Console.WriteLine("2. Hiển thị thí sinh trúng tuyển");
                Console.WriteLine("3. Tìm theo số báo danh");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                string? luaChon = Console.ReadLine(); // Made nullable to fix CS8600

                switch (luaChon)
                {
                    case "1": ts.NhapThiSinh(); break;
                    case "2": ts.HienThiTrungTuyen(); break;
                    case "3": ts.TimTheoSBD(); break;
                    case "4": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
                }
            }
        }
    }
}
