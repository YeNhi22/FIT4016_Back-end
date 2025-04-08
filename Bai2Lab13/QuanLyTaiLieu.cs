using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2Lab13
{
    internal class QuanLyTaiLieu
    {
        private List<TaiLieu> danhSach = new List<TaiLieu>();

        //Phuong thuc them tai lieu
        public void ThemTaiLieu()
        {
            Console.WriteLine("Chon loai tai lieu can them: ");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap chi");
            Console.WriteLine("3. Bao");
            Console.Write("Lua chon: ");
            int luaChon = int.Parse(Console.ReadLine() ?? "0");
            TaiLieu taiLieu;

            switch (luaChon)
            {
                case 1:
                    taiLieu = new Sach();
                    break;
                case 2:
                    taiLieu = new TapChi();
                    break;
                case 3:
                    taiLieu = new Bao();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }
            taiLieu.Nhap();
            danhSach.Add(taiLieu);
        }

        //Phuong thuc hien thi danh sach tai lieu
        public void HienThiDanhSach()
        {
            foreach (var taiLieu in danhSach)
            {
                taiLieu.Xuat();
                Console.WriteLine("------------------------------");
            }
        }

        public void TimKiemTheoLoai()
        {
            Console.WriteLine("Tìm loại: 1. Sách  2. Tạp chí  3. Báo");
            string chon = Console.ReadLine();

            Console.WriteLine("=== Kết quả tìm kiếm ===");
            foreach (var item in danhSach)
            {
                if ((chon == "1" && item is Sach) ||
                    (chon == "2" && item is TapChi) ||
                    (chon == "3" && item is Bao))
                {
                    item.Xuat();
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}
