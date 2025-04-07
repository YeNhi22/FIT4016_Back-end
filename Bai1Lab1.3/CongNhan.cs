using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;

namespace Bai1Lab1._3
{
    internal class CongNhan : CanBo
    {
        public int Bac { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập bậc: ");
            Bac = int.Parse(Console.ReadLine());
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bậc: {Bac}");
        }
    }
}
