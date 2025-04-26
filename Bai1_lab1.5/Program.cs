using System;
using System.Collections.Generic;

namespace Bai1_lab1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhanSo> danhSachPhanSo = new List<PhanSo>();

            Console.Write("Nhap so luon phan so muon tinh tong: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\nNhap phan so thu {i + 1}:");
                    PhanSo phanSo = PhanSoIO.NhapPhanSo();
                    danhSachPhanSo.Add(phanSo);
                    PhanSoIO.HienThiPhanSo("Ban da nhap:", phanSo);
                }

                if (danhSachPhanSo.Count == 0)
                {
                    Console.WriteLine("Danh sach phan so rong.");
                }
                else
                {
                    PhanSo tongPhanSo = new PhanSo(0, 1);
                    foreach (PhanSo phanSo in danhSachPhanSo)
                    {     
                        Console.WriteLine($"Phan so trong danh sach: ");
                        phanSo.Xuat();
                    }
                    Console.WriteLine("\nChua thuc hien tinh tong.");
                }
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen hop le.");
            }

            Console.ReadKey();
        }
    }
}