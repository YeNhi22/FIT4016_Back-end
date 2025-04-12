using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab13
{
    internal class KhuPho
    {
        private List<HoGiaDinh> danhSachHoGD = new List<HoGiaDinh>();

        public void NhapDanhSach()
        {
            Console.Write("Nhập số hộ dân: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin hộ dân thứ {i + 1}:");
                HoGiaDinh ho = new HoGiaDinh();
                ho.NhapThongTin();
                danhSachHoGD.Add(ho);
            }
        }

        public void HienThiTatCa()
        {
            foreach (var ho in danhSachHoGD)
            {
                ho.HienThiThongTin();
                Console.WriteLine("------------------------------");
            }
        }

        public void TimTheoTen()
        {
            Console.Write("Nhập họ tên cần tìm: ");
            string hoTen = Console.ReadLine();
            foreach (var ho in danhSachHoGD)
            {
                if (ho.TimTheoHoTen(hoTen))
                {
                    ho.HienThiThongTin();
                }
            }
        }

        public void TimTheoSoNha()
        {
            Console.Write("Nhập số nhà cần tìm: ");
            string soNha = Console.ReadLine();
            foreach (var ho in danhSachHoGD)
            {
                if (ho.SoNha == soNha)
                {
                    ho.HienThiThongTin();
                }
            }
        }
    }
}
