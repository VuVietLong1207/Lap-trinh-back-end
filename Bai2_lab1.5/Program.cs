using System;
using System.Collections.Generic;

namespace Bai2_TinhHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HInh> danhSachHinh = new List<HInh>();

            // Thêm các hình vào danh sách
            danhSachHinh.Add(new HinhTron(5));
            danhSachHinh.Add(new HinhVuong(4));
            danhSachHinh.Add(new HinhTamGiac(3, 4, 5)); // Tam giác vuông
            danhSachHinh.Add(new HinhChuNhat(6, 8));

            double tongChuVi = 0;
            double tongDienTich = 0;

            foreach (HInh hinh in danhSachHinh)
            {
                tongChuVi += hinh.TinhChuVi();
                tongDienTich += hinh.TinhDienTich();

                Console.WriteLine($"Loại hình: {hinh.GetType().Name}");
                Console.WriteLine($"Chu vi: {hinh.TinhChuVi():F2}");
                Console.WriteLine($"Diện tích: {hinh.TinhDienTich():F2}");
                Console.WriteLine("------------------");
            }

            Console.WriteLine($"\nTổng chu vi tất cả các hình: {tongChuVi:F2}");
            Console.WriteLine($"Tổng diện tích tất cả các hình: {tongDienTich:F2}");

            Console.ReadKey();
        }
    }
}