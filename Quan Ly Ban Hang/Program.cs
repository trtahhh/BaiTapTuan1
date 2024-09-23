using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ban_Hang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SanPham> dSSP = new List<SanPham>();   
            int n = 0;
            Console.Write("Nhap so luong san pham: ");  n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"San pham thu {i + 1}: ");
                SanPham spham = new SanPham();
                spham.Input();
                dSSP.Add(spham);
            }
            TongGia(dSSP);

            Console.ReadKey();
        }
        public static void TongGia(List<SanPham> dSSP)
        {
            var TongGia = dSSP.Sum(s => s.Gia);
            Console.WriteLine("Tong so tien la: " + TongGia);
        }
    }
}
