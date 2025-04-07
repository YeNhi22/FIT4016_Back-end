using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai1Lab1._3
{
    internal class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập công việc: ");
            CongViec = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Công việc: {CongViec}");
        }
    }
}
