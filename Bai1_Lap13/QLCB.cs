using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Lap13
{
    internal class QLCB
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void NhapCanBo()
        {
            Console.WriteLine("Ban muon nhap thong tin cho:");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien");
            Console.Write("Chon loai can bo (1/2/3): ");
            string choice = Console.ReadLine();

            CanBo canBoMoi = null;

            switch (choice)
            {
                case "1":
                    canBoMoi = new CongNhan();
                    Console.WriteLine("\nNhap thong tin Cong nhan:");
                    canBoMoi.Nhap();
                    break;
                case "2":
                    canBoMoi = new KySu();
                    Console.WriteLine("\nNhap thong tin Ky su:");
                    canBoMoi.Nhap();
                    break;
                case "3":
                    canBoMoi = new NhanVien();
                    Console.WriteLine("\nNhap thong tin Nhan vien:");
                    canBoMoi.Nhap();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    return;
            }

            if (canBoMoi != null)
            {
                danhSachCanBo.Add(canBoMoi);
                Console.WriteLine("Da them can bo moi.");
            }
        }

        public void TimKiemTheoHoTen(string ten)
        {
            bool timThay = false;
            foreach (var canBo in danhSachCanBo)
            {
                if (canBo.HoTenProp != null && canBo.HoTenProp.ToLower().Contains(ten.ToLower()))
                {
                    Console.WriteLine("\nThong tin can bo tim thay:");
                    canBo.Xuat();
                    timThay = true;
                }
            }
            if (!timThay)
            {
                Console.WriteLine($"Khong tim thay can bo nao co ho ten '{ten}'.");
            }
        }

        public void HienThiDanhSachCanBo()
        {
            if (danhSachCanBo.Count == 0)
            {
                Console.WriteLine("Danh sach can bo trong.");
                return;
            }
            Console.WriteLine("\n--- Danh sach can bo ---");
            foreach (var canBo in danhSachCanBo)
            {
                canBo.Xuat();
                Console.WriteLine("-----------------------");
            }
        }
    }
}