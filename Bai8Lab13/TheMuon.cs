using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8Lab13
{
    internal class TheMuon
    {
        public string SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string SoHieuSach { get; set; }
        public SinhVien SinhVien { get; set; } = new SinhVien();

        public void Nhap()
        {
            Console.WriteLine("=== Nhập thông tin thẻ mượn ===");
            Console.Write("Số phiếu mượn: ");
            SoPhieuMuon = Console.ReadLine();

            Console.Write("Ngày mượn (yyyy-MM-dd): ");
            NgayMuon = DateTime.Parse(Console.ReadLine());

            Console.Write("Hạn trả (yyyy-MM-dd): ");
            HanTra = DateTime.Parse(Console.ReadLine());

            Console.Write("Số hiệu sách: ");
            SoHieuSach = Console.ReadLine();

            SinhVien.Nhap();
        }

        public void HienThi()
        {
            Console.WriteLine($"Số phiếu: {SoPhieuMuon}, Ngày mượn: {NgayMuon:yyyy-MM-dd}, Hạn trả: {HanTra:yyyy-MM-dd}, Số hiệu sách: {SoHieuSach}");
            SinhVien.HienThi();
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
