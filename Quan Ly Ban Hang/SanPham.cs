using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang
{
    internal class SanPham
    {
        private string ten;
        private int gia;

        public string Ten { get; set; }
        public int Gia { get; set; }

        public SanPham(){}
        public SanPham(string ten, int gia)
        {
            this.ten = ten;
            this.gia = gia;
        }

        public void Input()
        {
            Console.Write("Nhap ten san pham: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap gia san pham: ");
            Gia = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Ten: {Ten}, \nGia: {Gia}");
        }
    }
}
