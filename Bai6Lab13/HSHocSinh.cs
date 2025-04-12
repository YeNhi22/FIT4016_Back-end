using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6Lab13
{
    internal class HSHocSinh : Nguoi
    {
        public string Lop { get; set; }
        public string KhoaHoc { get; set; }
        public string KyHoc { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Lớp: ");
            Lop = Console.ReadLine();
            Console.Write("Khoá học: ");
            KhoaHoc = Console.ReadLine();
            Console.Write("Kỳ học: ");
            KyHoc = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Lớp: {Lop}, Khoá học: {KhoaHoc}, Kỳ học: {KyHoc}");
        }
    }
}
