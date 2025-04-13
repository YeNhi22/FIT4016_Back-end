using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13Lab13
{
    internal class XeTai : PTGT
    {
        public double TrongTai { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Trọng tải (tấn): ");
            TrongTai = double.Parse(Console.ReadLine());
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Trọng tải: {TrongTai} tấn");
        }
    }
}
