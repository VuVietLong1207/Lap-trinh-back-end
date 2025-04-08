using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Lap13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyTailieu qltl = new QuanLyTailieu();
            int choice;

            do
            {
                Console.WriteLine("\n--- CHUONG TRINH QUAN LY THU VIEN ---");
                Console.WriteLine("1. Nhap thong tin tai lieu moi");
                Console.WriteLine("2. Hien thi thong tin tat ca tai lieu");
                Console.WriteLine("3. Tim kiem tai lieu theo loai");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Nhap lua chon: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            qltl.NhapTaiLieu();
                            break;
                        case 2:
                            qltl.HienThiDanhSachTaiLieu();
                            break;
                        case 3:
                            qltl.TimKiemTheoLoai();
                            break;
                        case 0:
                            Console.WriteLine("Thoat chuong trinh. Xin chao!");
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le. Vui long nhap lai.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so hop le.");
                }
            } while (choice != 0);
        }
    }
}