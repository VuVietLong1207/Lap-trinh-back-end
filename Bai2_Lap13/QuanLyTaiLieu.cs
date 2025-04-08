using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Lap13
{
    internal class QuanLyTailieu
    {
        private List<tailieu> danhSachTaiLieu = new List<tailieu>();

        public void NhapTaiLieu()
        {
            Console.WriteLine("Ban muon nhap thong tin cho loai tai lieu nao?");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap chi");
            Console.WriteLine("3. Bao");
            Console.Write("Chon loai (1/2/3): ");
            string choice = Console.ReadLine();

            tailieu? tl = null;

            switch (choice)
            {
                case "1":
                    tl = new Sach();
                    Console.WriteLine("\nNhap thong tin Sach:");
                    tl.Nhap();
                    break;
                case "2":
                    tl = new TapChi();
                    Console.WriteLine("\nNhap thong tin Tap chi:");
                    tl.Nhap();
                    break;
                case "3":
                    tl = new Bao();
                    Console.WriteLine("\nNhap thong tin Bao:");
                    tl.Nhap();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    return;
            }

            if (tl != null)
            {
                danhSachTaiLieu.Add(tl);
                Console.WriteLine("Da them tai lieu moi.");
            }
        }

        public void HienThiDanhSachTaiLieu()
        {
            if (danhSachTaiLieu.Count == 0)
            {
                Console.WriteLine("Danh sach tai lieu trong.");
                return;
            }
            Console.WriteLine("\n--- Danh sach tai lieu ---");
            foreach (var tl in danhSachTaiLieu)
            {
                tl.Xuat();
                Console.WriteLine("-----------------------");
            }
        }

        public void TimKiemTheoLoai()
        {
            Console.WriteLine("Ban muon tim kiem theo loai tai lieu nao?");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap chi");
            Console.WriteLine("3. Bao");
            Console.Write("Chon loai (1/2/3): ");
            string choice = Console.ReadLine();
            bool timThay = false;

            Console.WriteLine("\n--- Ket qua tim kiem ---");
            switch (choice)
            {
                case "1":
                    foreach (var tl in danhSachTaiLieu)
                    {
                        if (tl is Sach)
                        {
                            tl.Xuat();
                            Console.WriteLine("-----------------------");
                            timThay = true;
                        }
                    }
                    break;
                case "2":
                    foreach (var tl in danhSachTaiLieu)
                    {
                        if (tl is TapChi)
                        {
                            tl.Xuat();
                            Console.WriteLine("-----------------------");
                            timThay = true;
                        }
                    }
                    break;
                case "3":
                    foreach (var tl in danhSachTaiLieu)
                    {
                        if (tl is Bao)
                        {
                            tl.Xuat();
                            Console.WriteLine("-----------------------");
                            timThay = true;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    return;
            }

            if (!timThay)
            {
                Console.WriteLine("Khong tim thay tai lieu nao thuoc loai nay.");
            }
        }
    }
}