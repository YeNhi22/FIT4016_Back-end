using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai10Lab13
{
    internal class VanBan
    {
        private string noiDung;

        // Hàm tạo không đối
        public VanBan()
        {
            noiDung = "";
        }

        // Hàm tạo có đối số
        public VanBan(string st)
        {
            noiDung = st;
        }

        // Phương thức đếm số từ trong xâu
        public int DemSoTu()
        {
            if (string.IsNullOrWhiteSpace(noiDung))
                return 0;

            string[] tu = noiDung.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return tu.Length;
        }

        // Phương thức đếm ký tự 'H' hoặc 'h'
        public int DemSoKyTuH()
        {
            int dem = 0;
            foreach (char c in noiDung)
            {
                if (char.ToLower(c) == 'h')
                    dem++;
            }
            return dem;
        }

        // Phương thức chuẩn hóa xâu
        public string ChuanHoa()
        {
            string s = noiDung.Trim(); // Xóa khoảng trắng đầu/cuối
            s = Regex.Replace(s, @"\s+", " "); // Xóa khoảng trắng dư
            return s;
        }

        // Phương thức cập nhật nội dung từ người dùng
        public void NhapNoiDung()
        {
            Console.Write("Nhập nội dung văn bản: ");
            noiDung = Console.ReadLine();
        }

        // Hiển thị nội dung hiện tại
        public void HienThiNoiDung()
        {
            Console.WriteLine("Nội dung hiện tại: " + noiDung);
        }
    }
}
