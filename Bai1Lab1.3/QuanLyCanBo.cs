using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai1Lab1._3
{
    internal class QuanLyCanBo
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void ThemCanBo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Chọn loại cán bộ để thêm");
            Console.WriteLine("1. Công nhân");
            Console.WriteLine("2. Kỹ sư");
            Console.WriteLine("3. Nhân viên");
            Console.Write("Lựa chọn của bạn: ");
            int luaChon = int.Parse(Console.ReadLine());

            CanBo canBo = null;
            switch (luaChon)
            {
                case 1:
                    canBo = new CongNhan();
                    break;
                case 2:
                    canBo = new KySu();
                    break;
                case 3:
                    canBo = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }

            canBo.Nhap();
            danhSachCanBo.Add(canBo);
            Console.WriteLine("Thêm cán bộ thành công.\n");
        }

        public void TimKiem()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập họ tên cán bộ cần tìm: ");
            string hoTen = Console.ReadLine();

            bool timThay = false;
            foreach (var canBo in danhSachCanBo)
            {
                if (canBo.HoTen.ToLower().Contains(hoTen.ToLower()))
                {
                    Console.WriteLine("Thông tin cán bộ tìm thấy:");
                    canBo.HienThi();
                    Console.WriteLine("------------------------------");
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy cán bộ nào.");
            }
        }

        public void HienThiDanhSach()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n----Danh sách cán bộ ----");
            foreach (var canBo in danhSachCanBo)
            {
                canBo.HienThi();
                Console.WriteLine("------------------------------");
            }
        }
    }
}
