using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19Lab13
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<ThiSinh> danhSach = new List<ThiSinh>();

            Console.Write("Nhập số lượng thí sinh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin thí sinh thứ {i + 1}:");
                ThiSinh ts = new ThiSinh();
                ts.NhapThongTin();
                danhSach.Add(ts);
            }

            Console.WriteLine("\n=== Danh sách các thí sinh có tổng điểm > 15 ===");
            foreach (var ts in danhSach.Where(t => t.TongDiem() > 15))
            {
                ts.XuatBang();
            }

            Console.WriteLine("\n=== Danh sách sắp xếp theo tổng điểm giảm dần ===");
            var danhSachSapXep = danhSach.OrderByDescending(t => t.TongDiem()).ToList();
            foreach (var ts in danhSachSapXep)
            {
                ts.XuatBang();
            }
        }
    }

    struct HoTen
    {
        public string Ho;
        public string TenDem;
        public string Ten;

        public override string ToString() => $"{Ho} {TenDem} {Ten}";
    }

    struct QueQuan
    {
        public string Xa;
        public string Huyen;
        public string Tinh;

        public override string ToString() => $"{Xa}, {Huyen}, {Tinh}";
    }

    struct Diem
    {
        public float Toan;
        public float Ly;
        public float Hoa;

        public float Tong => Toan + Ly + Hoa;
    }

    class ThiSinh
    {
        public HoTen HoTen;
        public QueQuan QueQuan;
        public string Truong;
        public int Tuoi;
        public string SoBaoDanh;
        public Diem Diem;

        public void NhapThongTin()
        {
            Console.Write("Họ: ");
            HoTen.Ho = Console.ReadLine();
            Console.Write("Tên đệm: ");
            HoTen.TenDem = Console.ReadLine();
            Console.Write("Tên: ");
            HoTen.Ten = Console.ReadLine();

            Console.Write("Xã: ");
            QueQuan.Xa = Console.ReadLine();
            Console.Write("Huyện: ");
            QueQuan.Huyen = Console.ReadLine();
            Console.Write("Tỉnh: ");
            QueQuan.Tinh = Console.ReadLine();

            Console.Write("Trường: ");
            Truong = Console.ReadLine();
            Console.Write("Tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Số báo danh: ");
            SoBaoDanh = Console.ReadLine();

            Console.Write("Điểm Toán: ");
            Diem.Toan = float.Parse(Console.ReadLine());
            Console.Write("Điểm Lý: ");
            Diem.Ly = float.Parse(Console.ReadLine());
            Console.Write("Điểm Hóa: ");
            Diem.Hoa = float.Parse(Console.ReadLine());
        }

        public float TongDiem() => Diem.Tong;

        public void XuatBang()
        {
            Console.WriteLine($"Họ tên: {HoTen} | Quê quán: {QueQuan} | SBD: {SoBaoDanh} | Toán: {Diem.Toan} | Lý: {Diem.Ly} | Hóa: {Diem.Hoa} | Tổng: {TongDiem()}");
        }
    }
}

