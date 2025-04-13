using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20Lab13
{
    internal class DaCoNguoiYeu : HoiVien
    {
        public string TenNguoiYeu { get; set; }
        public string SDTNguoiYeu { get; set; }

        public DaCoNguoiYeu() : base("", "") { }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập tên người yêu: ");
            TenNguoiYeu = Console.ReadLine();
            Console.Write("Nhập số điện thoại người yêu: ");
            SDTNguoiYeu = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Người yêu: {TenNguoiYeu}, SĐT: {SDTNguoiYeu}");
        }

        public override bool CoNguoiYeuChuaCuoi() => true;
    }
}

