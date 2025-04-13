using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13Lab13
{
    internal class OTo : PTGT
    {
        public int SoChoNgoi { get; set; }
        public string KieuDongCo { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số chỗ ngồi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Kiểu động cơ: ");
            KieuDongCo = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Số chỗ: {SoChoNgoi}, Động cơ: {KieuDongCo}");
        }
    }
}
