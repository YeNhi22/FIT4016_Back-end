using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20Lab13
{
    internal class DaCoGiaDinh : HoiVien
    {
        public string TenVoChong { get; set; }
        public DateTime NgayCuoi { get; set; }

        public DaCoGiaDinh() : base("", "") { }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhập tên vợ/chồng: ");
            TenVoChong = Console.ReadLine();
            Console.Write("Nhập ngày cưới (dd/MM/yyyy): ");
            NgayCuoi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Vợ/Chồng: {TenVoChong}, Ngày cưới: {NgayCuoi:dd/MM/yyyy}");
        }

        public override bool CoNgayCuoi11_11_2011()
        {
            return NgayCuoi == new DateTime(2011, 11, 11);
        }
    }
}
