using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            VanBan vb = new VanBan();
            vb.NhapNoiDung();

            while (true)
            {
                Console.WriteLine("\n===== MENU XỬ LÝ VĂN BẢN =====");
                Console.WriteLine("1. Đếm số từ trong văn bản");
                Console.WriteLine("2. Đếm số ký tự 'H' (không phân biệt hoa thường)");
                Console.WriteLine("3. Chuẩn hóa văn bản");
                Console.WriteLine("4. Hiển thị nội dung văn bản");
                Console.WriteLine("5. Nhập nội dung văn bản mới");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                string chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine("Số từ trong văn bản: " + vb.DemSoTu());
                        break;
                    case "2":
                        Console.WriteLine("Số ký tự 'H' hoặc 'h': " + vb.DemSoKyTuH());
                        break;
                    case "3":
                        string chuanHoa = vb.ChuanHoa();
                        Console.WriteLine("Văn bản sau khi chuẩn hóa: " + chuanHoa);
                        break;
                    case "4":
                        vb.HienThiNoiDung();
                        break;
                    case "5":
                        vb.NhapNoiDung();
                        break;
                    case "0":
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
