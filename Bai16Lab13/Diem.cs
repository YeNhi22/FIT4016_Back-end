using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16Lab13
{
    internal class Diem
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Diem()
        {
            X = 0;
            Y = 0;
        }

        public Diem(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Nhap()
        {
            Console.Write("Nhập hoành độ: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ: ");
            Y = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"({X}, {Y})");
        }

        public double TinhKhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(X - d.X, 2) + Math.Pow(Y - d.Y, 2));
        }
    }
}
