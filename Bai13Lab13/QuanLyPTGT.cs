using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13Lab13
{
    internal class QuanLyPTGT
    {
        private List<PTGT> danhSach = new List<PTGT>();

        public void NhapPhuongTien()
        {
            Console.WriteLine("1. Ô tô\n2. Xe máy\n3. Xe tải");
            Console.Write("Chọn loại phương tiện: ");
            int loai = int.Parse(Console.ReadLine());
            PTGT pt;
            switch (loai)
            {
                case 1:
                    pt = new OTo();
                    break;
                case 2:
                    pt = new XeMay();
                    break;
                case 3:
                    pt = new XeTai();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }
            pt.Nhap();
            danhSach.Add(pt);
        }

        public void HienThi()
        {
            foreach (var pt in danhSach)
            {
                pt.HienThi();
                Console.WriteLine("------------------");
            }
        }

        public void TimTheoMau()
        {
            Console.Write("Nhập màu cần tìm: ");
            string mau = Console.ReadLine();
            foreach (var pt in danhSach)
            {
                if (pt.Mau.Equals(mau, StringComparison.OrdinalIgnoreCase))
                {
                    pt.HienThi();
                    Console.WriteLine("------------------");
                }
            }
        }

        public void TimTheoNam()
        {
            Console.Write("Nhập năm sản xuất cần tìm: ");
            int nam = int.Parse(Console.ReadLine());
            foreach (var pt in danhSach)
            {
                if (pt.NamSanXuat == nam)
                {
                    pt.HienThi();
                    Console.WriteLine("------------------");
                }
            }
        }
    }
}
