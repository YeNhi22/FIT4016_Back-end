using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<BienLai> danhSachBienLai = new List<BienLai>();

            Console.Write("Nhập số hộ dân: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin hộ dân thứ {i + 1}:");
                BienLai bl = new BienLai();
                bl.NhapBienLai();
                danhSachBienLai.Add(bl);
            }

            Console.WriteLine("\n=== Danh sách biên lai đã nhập ===");
            foreach (var bl in danhSachBienLai)
            {
                bl.HienThiBienLai();
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
