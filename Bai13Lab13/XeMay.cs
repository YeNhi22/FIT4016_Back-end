using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13Lab13
{
    internal class XeMay : PTGT
    {
        public double CongSuat { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Công suất: ");
            CongSuat = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Công suất: {CongSuat} mã lực");
        }
    }
}
