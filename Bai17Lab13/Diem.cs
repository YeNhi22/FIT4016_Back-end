using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17Lab13
{
    internal class Diem
    {
        public float x { get; set; }
        public float y { get; set; }

        public Diem() { }

        public Diem(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Nhap()
        {
            Console.Write("Nhập hoành độ x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ y: ");
            y = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"({x}, {y})");
        }

        public double TinhKhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(x - d.x, 2) + Math.Pow(y - d.y, 2));
        }
    }
}
