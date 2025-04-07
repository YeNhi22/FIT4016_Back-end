using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.OutputEncoding = System.Text.Encoding.UTF8;


namespace Bai1Lab1._3
{
    internal class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập ngành đào tạo: ");
            NganhDaoTao = Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}");
        }
    }
}
